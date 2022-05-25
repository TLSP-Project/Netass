

using System.Reflection;

using RestSharp.Serializers.Json;


using System.Net;

using System.Linq.Expressions;
using System.Net.Http;

namespace TLSP.Netass.WebSrv
{



    public class WebSrvProvider
    {


        private class ContainerInfo
        {
            public Type ClassType { get; set; }

            public ApiCallInfo[] CallInfos { get; set; }
        }

        private class ApiCallInfo
        {
            public MethodInfo Method { get; set; }

            public Expression[] CallPameters { get; set; }

            public ParameterExpression? BodyPameter { get; set; }

            public FieldInfo Field { get; set; }
        }


        public static readonly Dictionary<int, string> ErrCodeDICT;




        private static readonly RestClientOptions clientOptions = new RestClientOptions(X19ServerHelper.ServerConfig.WebServerUrl)
        {
            UserAgent = "WPFLuancher/" + X19ServerHelper.NewestWPFVersion.versionStr
        };


        private static readonly ContainerInfo[] containerInfos;

        [WebSrvApiBase]
        public delegate Task<WebSrvResponse<ResponseType>> PostEntityDelegate<ResponseType, RequestBodyType>(RequestBodyType requestEntity);

        [WebSrvApiBase(true)]
        public delegate Task<WebSrvListResponse<ResponseType>> PostEntityListDelegate<ResponseType, RequestBodyType>(RequestBodyType requestEntity);



        [WebSrvApiBase]
        public delegate Task<WebSrvResponse<ResponseType>> GetEntityDelegate<ResponseType>();

        [WebSrvApiBase(true)]
        public delegate Task<WebSrvListResponse<ResponseType>> GetEntityListDelegate<ResponseType>();


        static WebSrvProvider()
        {
            ServicePointManager.DefaultConnectionLimit = 1024;
            WebRequest.DefaultWebProxy = null;
            ServicePointManager.Expect100Continue = false;
            ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls12;

            var WebSrvApiAttributeType = typeof(WebSrvApiAttribute);

            Dictionary<bool, MethodInfo> baseMethodDIC = new();

            //构建基础方法Dic
            foreach (var method in typeof(WebSrvProvider).GetMethods()
                .Where(m => m.IsDefined(typeof(WebSrvApiBaseAttribute))))
            {
                baseMethodDIC.Add(method.GetCustomAttribute<WebSrvApiBaseAttribute>().IsList, method);
            }

            var containerInfoList = new List<ContainerInfo>();

            //筛选define WebSrvApi的类
            foreach (var type in Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(t => t.IsClass && t.IsDefined(WebSrvApiAttributeType)))
            {


                var containerInfo = new ContainerInfo()
                {
                    ClassType = type,
                };

                var callInfos = new List<ApiCallInfo>();
                //筛选define WebSrvApi的委托字段
                foreach (var field in type.GetFields()
                    .Where(t => t.IsDefined(WebSrvApiAttributeType)))
                {

                    var callInfo = new ApiCallInfo()
                    {
                        Field = field
                    };
                    //获取对WebSrvApi的描述
                    var attribute = field.GetCustomAttribute<WebSrvApiAttribute>();

                    //获取实现的泛型类型从dic拿到泛型基础方法的MethodInfo并重载泛型方法
                    var baseMethod = baseMethodDIC[field.FieldType.GetGenericTypeDefinition().GetCustomAttribute<WebSrvApiBaseAttribute>().IsList].MakeGenericMethod(field.FieldType.GenericTypeArguments[0]);

                    callInfo.Method = baseMethod;

                    //构建call的参数列表
                    Expression bodyPameter;
                    var callPameters = new List<Expression>();


                    //判断是否有body参数
                    if (field.FieldType.GenericTypeArguments.Length == 1)
                        bodyPameter = Expression.Constant(null);
                    else
                        bodyPameter = Expression.Parameter(field.FieldType.GenericTypeArguments[1]);


                    //构建call参数
                    callPameters.Add(bodyPameter);
                    callPameters.Add(Expression.Constant(attribute.ApiRes));
                    callPameters.Add(Expression.Constant(attribute.Method));
                    callPameters.Add(Expression.Constant(attribute.EncryptionType));
                    callPameters.Add(Expression.Constant(attribute.LockToken));

                    callInfo.CallPameters = callPameters.ToArray();


                    //构建委托
                    if (bodyPameter is ParameterExpression parameter)
                        callInfo.BodyPameter = parameter;

                    callInfos.Add(callInfo);

                }

                containerInfo.CallInfos = callInfos.ToArray();
                containerInfoList.Add(containerInfo);
            }
            containerInfos = containerInfoList.ToArray();

            ErrCodeDICT = new Dictionary<int, string>
            {
                {
                    -123456,
                    "Response Data is Null"
                },
                {
                    -18,
                    "网络异常（服务器提交了协议冲突）"
                },
                {
                    -17,
                    "网络异常（无法从传输连接中读取数据: 连接已关闭）"
                },
                {
                    -16,
                    "网络异常（基础连接已经关闭: 接收时发生错误）"
                },
                {
                    -15,
                    "网络异常（基础连接已经关闭: 发送时发生错误）"
                },
                {
                    -14,
                    "网络异常（无法连接到远程服务器）"
                },
                {
                    -13,
                    "网络异常（未能解析此远程名称）"
                },
                {
                    -12,
                    "网络异常（请求被中止: 未能创建 SSL/TLS 安全通道）"
                },
                {
                    -11,
                    "网络异常（操作超时）"
                },
                {
                    -10,
                    "网络异常（请求超时）"
                },
                {
                    -4,
                    "[JsonDeserialize]"

                },
                {
                    0,
                    string.Empty
                },
                {
                    1,
                    "用户名或密码错误"
                },
                {
                    2,
                    "无法识别的请求"
                },
                {
                    3,
                    "URS验证不通过，具体内容参考data数据"
                },
                {
                    4,
                    "参数为空"
                },
                {
                    5,
                    "昵称格式不合法"
                },
                {
                    6,
                    "用户不存在"
                },
                {
                    7,
                    "昵称暂不支持修改"
                },
                {
                    8,
                    "昵称已存在"
                },
                {
                    9,
                    "包含敏感词"
                },
                {
                    10,
                    "登录已失效"
                },
                {
                    11,
                    "实名认证失败"
                },
                {
                    12,
                    "参数错误"
                },
                {
                    13,
                    "操作失败"
                },
                {
                    14,
                    "参数超出长度范围"
                },
                {
                    17,
                    "只允许使用中英文字符和数字"
                },
                {
                    21,
                    "您的账号尚未获得测试资格，请激活后再来登录。"
                },
                {
                    22,
                    "您的账号在另一处登录。"
                },
                {
                    23,
                    "目前服务器尚未开启，请于正式开服后再尝试登录。"
                },
                {
                    41,
                    "批量查询数量过多"
                },
                {
                    29,
                    "账号已被封禁！"
                },
                {
                    100,
                    "上传失败"
                },
                {
                    200,
                    "凭证过期"
                },
                {
                    201,
                    "凭证错误"
                },
                {
                    300,
                    "套餐不存在"
                },
                {
                    301,
                    "套餐获取失败"
                },
                {
                    302,
                    "服务器不存在"
                },
                {
                    303,
                    "服务器租赁时间过长"
                },
                {
                    304,
                    "服务器启动中"
                },
                {
                    305,
                    "未初始化的服务器数量达到上限"
                },
                {
                    306,
                    "Realms错误"
                },
                {
                    311,
                    "用户在黑名单"
                },
                {
                    307,
                    "已经初始化"
                },
                {
                    310,
                    "获取服务器信息失败"
                },
                {
                    308,
                    "切换世界失败"
                },
                {
                    309,
                    "不是服主"
                },
                {
                    312,
                    "请稍候重试"
                },
                {
                    313,
                    "您所能获取的租赁服数量达到上限"
                },
                {
                    314,
                    "游戏世界服务器已关闭"
                },
                {
                    315,
                    "服务器人数已满，请稍候重试！"
                },
                {
                    316,
                    "存档尚未生成，请至少进入一次游戏，生成存当后再备份世界"
                },
                {
                    802,
                    "角色删除后24小时后才能再删除其他角色"
                },
                {
                    -300,
                    "服务器状态异常！"
                },
                {
                    -1,
                    "未知错误"
                },
                {
                    -6,
                    "请求服务器返回超时"
                },
                {
                    400,
                    "未知绿宝石事件"
                },
                {
                    401,
                    "没有加上绿宝石"
                },
                {
                    402,
                    "达到次数上限"
                },
                {
                    403,
                    "等级不够"
                },
                {
                    20000,
                    "群组数量已达到上限"
                },
                {
                    20001,
                    "群人数已达上限"
                },
                {
                    20002,
                    "邀请已失效"
                },
                {
                    20003,
                    "操作失败,请稍后重试"
                },
                {
                    20004,
                    "您的权限不足"
                },
                {
                    20005,
                    "创建群组数量已达上限"
                },
                {
                    20006,
                    "名称长度超过可用上限"
                },
                {
                    20007,
                    "名称内包含敏感词"
                },
                {
                    20008,
                    "解散失败，距离上次解散还未满15天"
                },
                {
                    20009,
                    "该群已被解散"
                }
            };

        }


        private RestClient webSrvClient { get; }

        public Dictionary<Type,object> Containers { get; } = new Dictionary<Type, object>();


        public IX19ServiceProvider X19ServiceProvider { get; }

        internal static readonly JsonSerializerOptions serializerOptions = new JsonSerializerOptions()
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
            NumberHandling = JsonNumberHandling.AllowReadingFromString,
            PropertyNameCaseInsensitive = true,
            AllowTrailingCommas = true
        };


        public WebSrvProvider(IX19ServiceProvider serviceProvider)
        {
            X19ServiceProvider = serviceProvider;
            webSrvClient = new RestClient(clientOptions);
            webSrvClient.UseSystemTextJson(serializerOptions);

            foreach (var containerInfo in containerInfos)
            {
                var ins = Activator.CreateInstance(containerInfo.ClassType);
                Containers[containerInfo.ClassType] = ins;
                foreach (var callInfo in containerInfo.CallInfos)
                {

                    var callEx = Expression.Call(Expression.Constant(this),callInfo.Method,callInfo.CallPameters);

                    Delegate @delegate;

                    if(callInfo.BodyPameter == null)
                        @delegate=  Expression.Lambda(callInfo.Field.FieldType,callEx).Compile();
                    else
                        @delegate= Expression.Lambda(callInfo.Field.FieldType,callEx,callInfo.BodyPameter).Compile();

                    callInfo.Field.SetValue(ins, @delegate);



                }
            }



        }



        public T GetContainer<T>() => (T)Containers[typeof(T)];



        [WebSrvApiBase]
        public Task<WebSrvResponse<ResponseType>> Execute<ResponseType> (object requestEntity ,string res, Method method = Method.Post, EncryptionType encryptionType = EncryptionType.NoEncryption,bool lockToken =true) 
        {
            var request = new WebSrvRequest(res, method, encryptionType);
            if (requestEntity != null)
                request.AddJsonBody(requestEntity);

            return Execute<WebSrvResponse<ResponseType>>(request, lockToken);

        }

        [WebSrvApiBase(true )]
        public Task<WebSrvListResponse<ResponseType>> ExecuteList<ResponseType>(object requestEntity, string res, Method method = Method.Post, EncryptionType encryptionType = EncryptionType.NoEncryption, bool lockToken =true )
        {
            var request = new WebSrvRequest(res, method, encryptionType);
            if (requestEntity != null)
                request.AddJsonBody(requestEntity);

            return Execute<WebSrvListResponse<ResponseType>>(request, lockToken);

        }

        public async Task<T> Execute<T>(WebSrvRequest request , bool lockToken) where T : ResponseBase
        {
            var authEntity = X19ServiceProvider.AuthEntity;

            request.OnBeforeRequest += async (HttpRequestMessage requestMessage) =>
            {
                string? body = null;

                if (request.NeedEncrypt != EncryptionType.NoEncryption)
                {
                    body = await requestMessage.Content.ReadAsStringAsync();

                    requestMessage.Content = new ByteArrayContent(X19ServiceProvider.HttpEncrypt(request.Resource, body));
                }

                if (authEntity.Instanse?.Token != null)
                {
                    requestMessage.Headers.Add("user-id", authEntity.Instanse.EntityID);
                    requestMessage.Headers.Add("user-token", X19ServiceProvider.ComputeDynamicToken(request.Resource, body ?? await requestMessage.Content.ReadAsStringAsync()));
                }


            };

            switch (request.NeedEncrypt) 
            {
                case EncryptionType.LoginEncryption:
                    request.OnAfterRequest += async (HttpResponseMessage responseMessage) => responseMessage.Content = new StringContent(X19ServiceProvider.ParseLoginResponse(await responseMessage.Content.ReadAsByteArrayAsync()));

                    break;
                case EncryptionType.NormalEncryption:
                    request.OnAfterRequest += async (HttpResponseMessage responseMessage) =>
                    responseMessage.Content = new StringContent(X19ServiceProvider.HttpDecrypt(await responseMessage.Content.ReadAsByteArrayAsync()));
                    break;
            }






            RestResponse<T> response;

            if(lockToken)
                using(await authEntity.ReadLockAsync())
                    response = await webSrvClient.ExecuteAsync<T>(request).ConfigureAwait(true);
            else
                response = await webSrvClient.ExecuteAsync<T>(request).ConfigureAwait(true);

            switch (response.ResponseStatus)
            {
                case ResponseStatus.TimedOut:
                    throw new WebSrvApiException($"Api {clientOptions.BaseUrl}{request.Resource} 请求超时", request.Resource, JsonSerializer.Serialize(request.Parameters), response.Content);
                case ResponseStatus.Completed:
                    {
                        if (response.StatusCode == HttpStatusCode.NotFound)
                            throw new WebSrvApiException($"Api {clientOptions.BaseUrl}{request.Resource}  请求失败:404 NotFound", request.Resource, JsonSerializer.Serialize(request.Parameters), response.Content);
                        int code = response.Data.Code;

                        if (code != 0)
                        {
                            if (ErrCodeDICT.ContainsKey(code))
                                throw new WebSrvApiException($"Api  {clientOptions.BaseUrl}{request.Resource}  调用失败 错误码：{code} 错误信息：{ErrCodeDICT[code]}", request.Resource, JsonSerializer.Serialize(request.Parameters, serializerOptions), response.Content, response.Data);
                            else
                                throw new WebSrvApiException($"Api  {clientOptions.BaseUrl}{request.Resource}  调用失败 错误码：{code} 错误信息：{response.Data?.Message}", request.Resource, JsonSerializer.Serialize(request.Parameters, serializerOptions), response.Content, response.Data);
                        }else
                            return response.Data;
                    }
                case ResponseStatus.Aborted:
                    throw new WebSrvApiException(response.ErrorException,$"Api {clientOptions.BaseUrl}{request.Resource} 调用中止 错误信息:{response.ErrorMessage}", request.Resource, JsonSerializer.Serialize(request.Parameters, serializerOptions), response.Content);
                case ResponseStatus.Error:
                    throw new WebSrvApiException(response.ErrorException, $"Api {clientOptions.BaseUrl}{request.Resource} 调用时发生异常 错误信息:{response.ErrorMessage}", request.Resource, JsonSerializer.Serialize(request.Parameters, serializerOptions), response.Content);
                default:
                    throw new WebSrvApiException(response.ErrorException, $"Api {clientOptions.BaseUrl}{request.Resource} 调用时发生未知错误 错误信息:{response.ErrorMessage}", request.Resource, JsonSerializer.Serialize(request.Parameters, serializerOptions), response.Content);


            }

        }

    }
}
