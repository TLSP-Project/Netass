
using Nito.AsyncEx;

namespace TLSP.Netass
{
    public class AuthEntityLocker
    {
        private readonly AsyncReaderWriterLock @lock = new AsyncReaderWriterLock();
        public AuthenticationEntity Instanse { get;  set; }

        public AuthEntityLocker(AuthenticationEntity ins)
        {
            Instanse = ins;
        }

         
        public AwaitableDisposable<IDisposable> ReadLockAsync() => @lock.ReaderLockAsync();

        

        public AwaitableDisposable<IDisposable> WriteLockAsync() => @lock.WriterLockAsync();

        public IDisposable Readock() => @lock.ReaderLock();



        public IDisposable WriteLock() => @lock.WriterLock();



    }
}
