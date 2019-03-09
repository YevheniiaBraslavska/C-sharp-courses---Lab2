namespace SimCorp.IMS.Lab2 {
    public abstract class ScreenAttribute {
        public abstract int Height { get; set; }
        public abstract int Width { get; set; }
        public abstract int DPI { get; set; }
        public abstract void Show(IScreenImage screenImage);
    }
}