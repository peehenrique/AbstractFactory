using AbstractFactory;

var factory = new AppleFactory();

var smartPhone = factory.MakeSmartPhone();

var tablet = factory.MakeTablet();

smartPhone.ShowInfo();

tablet.ShowInfo();
