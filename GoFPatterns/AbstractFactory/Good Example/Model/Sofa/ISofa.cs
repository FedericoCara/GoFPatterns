namespace GoFPatterns.AbstractFactory.GoodExample {
    public interface ISofa {

        int LegCount { get; }
        float Coziness { get; }
        void SitOn();
    }
}