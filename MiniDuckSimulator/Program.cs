using MiniDuckSimulator;
using MiniDuckSimulator.DuckBehaviors;
using MiniDuckSimulator.DuckBehaviors.FlyingBehaviors;

DuckBase mallard = new MallardDuck();
mallard.performQuack();
mallard.performFly();

DuckBase model = new ModelDuck();
model.performFly();
model.setFlyBehavior(new FlyRocketPowered());
model.performFly();
