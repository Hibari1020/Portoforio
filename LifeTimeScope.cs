using VContainer;
using VContainer.Unity;
using UnityEngine;

public sealed class LifeTimeScope : LifetimeScope
{
   [SerializeField]private MoneyNothing moneyNothing;
   [SerializeField]private DiceButton dicebutton;
   [SerializeField]private StartCube startCube;
   [SerializeField]private FinishCube finishCube;
   [SerializeField]private PlayerInstantiate playerInstantiate;
   [SerializeField]private SetActive setActive;
   [SerializeField]private RedCube1 redCube1;
   [SerializeField]private RedCube2 redCube2;
   [SerializeField]private RedCube3 redCube3;
   [SerializeField]private RedCube4 redCube4;
   [SerializeField]private RedCube5 redCube5;
   [SerializeField]private RedCube6 redCube6;
   [SerializeField]private RedCube7 redCube7;
   [SerializeField]private RedCube8 redCube8;
   [SerializeField]private RedCube9 redCube9;
   [SerializeField]private RedCube10 redCube10;
   [SerializeField]private BlueCube1 blueCube1;
   [SerializeField]private BlueCube2 blueCube2;
   [SerializeField]private BlueCube3 blueCube3;
   [SerializeField]private BlueCube4 blueCube4;
   [SerializeField]private BlueCube5 blueCube5;
   [SerializeField]private BlueCube6 blueCube6;
   [SerializeField]private BlueCube7 blueCube7;
   [SerializeField]private BlueCube8 blueCube8;
   [SerializeField]private BlueCube9 blueCube9;
   [SerializeField]private BlueCube10 blueCube10;
   [SerializeField]private NormalCube1 normalCube1;
   [SerializeField]private NormalCube2 normalCube2;
   [SerializeField]private NormalCube3 normalCube3;
   [SerializeField]private MoveCube1 moveCube1;
   [SerializeField]private MoveCube2 moveCube2;
   [SerializeField]private MoveCube3 moveCube3;
   [SerializeField]private MoveCube4 moveCube4;
   [SerializeField]private MoveCube5 moveCube5;
   

   protected override void Configure(IContainerBuilder builder)
   {
       builder.Register<IDiceManager, DiceManager>(Lifetime.Singleton);
       builder.Register<IGameStatus, GameStatus>(Lifetime.Singleton);
       builder.Register<IMoneyManager, MoneyManager>(Lifetime.Singleton);
       
       builder.RegisterComponent(moneyNothing);
       builder.RegisterComponent(dicebutton);
       builder.RegisterComponent(startCube);
       builder.RegisterComponent(playerInstantiate);
       builder.RegisterComponent(setActive);
       builder.RegisterComponent(finishCube);
       builder.RegisterComponent(redCube1);
       builder.RegisterComponent(redCube2);
       builder.RegisterComponent(redCube3);
       builder.RegisterComponent(redCube4);
       builder.RegisterComponent(redCube5);
       builder.RegisterComponent(redCube6);
       builder.RegisterComponent(redCube7);
       builder.RegisterComponent(redCube8);
       builder.RegisterComponent(redCube9);
       builder.RegisterComponent(redCube10);
       builder.RegisterComponent(blueCube1);
       builder.RegisterComponent(blueCube2);
       builder.RegisterComponent(blueCube3);
       builder.RegisterComponent(blueCube4);
       builder.RegisterComponent(blueCube5);
       builder.RegisterComponent(blueCube6);
       builder.RegisterComponent(blueCube7);
       builder.RegisterComponent(blueCube8);
       builder.RegisterComponent(blueCube9);
       builder.RegisterComponent(blueCube10);
       builder.RegisterComponent(normalCube1);
       builder.RegisterComponent(normalCube2);
       builder.RegisterComponent(normalCube3);
       builder.RegisterComponent(moveCube1);
       builder.RegisterComponent(moveCube2);
       builder.RegisterComponent(moveCube3);
       builder.RegisterComponent(moveCube4);
       builder.RegisterComponent(moveCube5);
   }
}
