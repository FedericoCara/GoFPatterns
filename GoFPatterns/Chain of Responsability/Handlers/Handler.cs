
namespace GoFPatterns.ChainOfResponsability {
    public abstract class Handler {
        protected Handler next;

        public void AddNext(Handler handler) {
            next = handler;
        }

        public abstract void Process(Purchase purchase);


    }
}