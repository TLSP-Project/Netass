

namespace TLSP.Netass.Entities
{
    [Serializable]
    public class ItemEntity : EntityBase
    {
        [JsonPropertyName("likes")]
        public ulong? Likes { get; set; }

        [JsonPropertyName("image_url")]
        public string? ImageURL { get; set; }

        [JsonPropertyName("has_purchased")]
        public bool? HasPuchased { get; set; }

        [JsonPropertyName("price")]
        public ulong? Price { get; set; }

        [JsonPropertyName("discount")]
        public float? Discount { get; set; }

        [JsonPropertyName("mc_version_name")]
        public string? MCVersionName { get; set; }

        [JsonPropertyName("vip_discount")]
        public float? VipDiscount { get; set; }

        [JsonPropertyName("balance_grade")]
        public int? BalanceGrade { get; set; }

        [JsonPropertyName("balance_scope")]
        public EItemBalanceGrade? BalanceScope { get; set; }

        [JsonPropertyName("is_apollo")]
        public int? IsApollo { get; set; }

        [JsonPropertyName("is_auth")]
        public bool? IsAuth { get; set; }

        [JsonPropertyName("online_count")]
        public int? OnlineCount { get; set; }

        [JsonPropertyName("rel_iid")]
        public int? RelIid { get; set; }

        [JsonPropertyName("resource_version")]
        public int? ResourceVersion { get; set; }

        [JsonPropertyName("available_scope")]
        public EItemAvailableScope AvailableScope { get; set; }

        [JsonPropertyName("brief_summary")]
        public string BriefSummary { get; set; }

        [JsonPropertyName("developer_name")]
        public string DeveloperName { get; set; }

        [JsonPropertyName("effect_mtypeid")]
        public int EffectMtypeid { get; set; }

        [JsonPropertyName("effect_stypeid")]
        public int EffectStypeid { get; set; }

        [JsonPropertyName("game_status")]
        public int GameStatus { get; set; }

        [JsonPropertyName("goods_state")]
        public EItemGoodsState GoodsState { get; set; }

        [JsonPropertyName("item_type")]
        public EItemType ItemType { get; set; }

        [JsonPropertyName("item_version")]
        public string ItemVersion { get; set; }

        [JsonPropertyName("lobby_max_num")]
        public uint LobbyMaxNum { get; set; }

        [JsonPropertyName("lobby_min_num")]
        public uint LobbyMinNum { get; set; }

        [JsonPropertyName("master_type_id")]
        public int MasterTypeID { get; set; }

        [JsonPropertyName("mod_id")]
        public ulong ModID { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }


        [JsonPropertyName("publish_time")]
        public ulong PublishTime { get; set; }


        [JsonPropertyName("review_status")]
        public EtemReviewStatus ReviewStatus { get; set; }

        [JsonPropertyName("season_begin")]
        public ulong SeasonBegin { get; set; }

        [JsonPropertyName("season_number")]
        public int SeasonNumber { get; set; }

        [JsonPropertyName("secondary_type_id")]
        public string SecondaryTypeId { get; set; }

        [JsonPropertyName("vip_only")]
        public bool VipOnly { get; set; }

    }
}
