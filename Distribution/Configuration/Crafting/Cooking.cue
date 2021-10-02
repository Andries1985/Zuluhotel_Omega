package Crafting

import (
	Types "github.com/zuluhotelaustralia/zuluhotel/Types"
)

Cooking: Types.#CraftSettings & {
	MainSkill:      "Cooking"
	GumpTitleId:    1044003
	MinCraftDelays: 3
	MaxCraftDelays: 3
	Delay:          2.0
	MinCraftChance: 0
	CraftWorkSound: 477
	CraftEndSound:  477
	CraftEntries: [
		{
			ItemType:  "SackFlour"
			Name:      1024153
			GroupName: 1044495
			Skill:     10
			NeedMill:  true
			Resources: [
				{
					ItemType: "WheatSheaf"
					Name:     1044489
					Amount:   2
					Message:  1044490
				},
			]
		},
		{
			ItemType:  "Dough"
			Name:      1024157
			GroupName: 1044495
			Skill:     10
			Resources: [
				{
					ItemType: "SackFlour"
					Name:     1044468
					Amount:   1
					Message:  1044253
				},
				{
					ItemType: "BaseBeverage"
					Name:     1046458
					Amount:   1
					Message:  1044253
				},
			]
		},
		{
			ItemType:  "SweetDough"
			Name:      1041340
			GroupName: 1044495
			Skill:     20
			Resources: [
				{
					ItemType: "Dough"
					Name:     1044469
					Amount:   1
					Message:  1044253
				},
				{
					ItemType: "JarHoney"
					Name:     1044472
					Amount:   1
					Message:  1044253
				},
			]
		},
		{
			ItemType:  "CakeMix"
			Name:      1041002
			GroupName: 1044495
			Skill:     20
			Resources: [
				{
					ItemType: "SackFlour"
					Name:     1044468
					Amount:   1
					Message:  1044253
				},
				{
					ItemType: "SweetDough"
					Name:     1044475
					Amount:   1
					Message:  1044253
				},
			]
		},
		{
			ItemType:  "CookieMix"
			Name:      1024159
			GroupName: 1044495
			Skill:     20
			Resources: [
				{
					ItemType: "JarHoney"
					Name:     1044472
					Amount:   1
					Message:  1044253
				},
				{
					ItemType: "SweetDough"
					Name:     1044475
					Amount:   1
					Message:  1044253
				},
			]
		},
		{
			ItemType:  "UnbakedQuiche"
			Name:      1041339
			GroupName: 1044496
			Skill:     20
			Resources: [
				{
					ItemType: "Dough"
					Name:     1044469
					Amount:   1
					Message:  1044253
				},
				{
					ItemType: "Eggs"
					Name:     1044477
					Amount:   1
					Message:  1044253
				},
			]
		},
		{
			ItemType:  "UnbakedMeatPie"
			Name:      1041338
			GroupName: 1044496
			Skill:     20
			Resources: [
				{
					ItemType: "Dough"
					Name:     1044469
					Amount:   1
					Message:  1044253
				},
				{
					ItemType: "RawRibs"
					Name:     1044482
					Amount:   1
					Message:  1044253
				},
			]
		},
		{
			ItemType:  "UncookedSausagePizza"
			Name:      1041337
			GroupName: 1044496
			Skill:     20
			Resources: [
				{
					ItemType: "Dough"
					Name:     1044469
					Amount:   1
					Message:  1044253
				},
				{
					ItemType: "Sausage"
					Name:     1044483
					Amount:   1
					Message:  1044253
				},
			]
		},
		{
			ItemType:  "UncookedCheesePizza"
			Name:      1041341
			GroupName: 1044496
			Skill:     20
			Resources: [
				{
					ItemType: "Dough"
					Name:     1044469
					Amount:   1
					Message:  1044253
				},
				{
					ItemType: "CheeseWheel"
					Name:     1044486
					Amount:   1
					Message:  1044253
				},
			]
		},
		{
			ItemType:  "UnbakedFruitPie"
			Name:      1041334
			GroupName: 1044496
			Skill:     20
			Resources: [
				{
					ItemType: "Dough"
					Name:     1044469
					Amount:   1
					Message:  1044253
				},
				{
					ItemType: "Pear"
					Name:     1044481
					Amount:   1
					Message:  1044253
				},
			]
		},
		{
			ItemType:  "UnbakedPeachCobbler"
			Name:      1041335
			GroupName: 1044496
			Skill:     20
			Resources: [
				{
					ItemType: "Dough"
					Name:     1044469
					Amount:   1
					Message:  1044253
				},
				{
					ItemType: "Peach"
					Name:     1044480
					Amount:   1
					Message:  1044253
				},
			]
		},
		{
			ItemType:  "UnbakedApplePie"
			Name:      1041336
			GroupName: 1044496
			Skill:     20
			Resources: [
				{
					ItemType: "Dough"
					Name:     1044469
					Amount:   1
					Message:  1044253
				},
				{
					ItemType: "Apple"
					Name:     1044479
					Amount:   1
					Message:  1044253
				},
			]
		},
		{
			ItemType:  "UnbakedPumpkinPie"
			Name:      1041342
			GroupName: 1044496
			Skill:     20
			Resources: [
				{
					ItemType: "Dough"
					Name:     1044469
					Amount:   1
					Message:  1044253
				},
				{
					ItemType: "Pumpkin"
					Name:     1044484
					Amount:   1
					Message:  1044253
				},
			]
		},
		{
			ItemType:  "BreadLoaf"
			Name:      1024156
			GroupName: 1044497
			Skill:     30
			NeedOven:  true
			Resources: [
				{
					ItemType: "Dough"
					Name:     1044469
					Amount:   1
					Message:  1044253
				},
			]
		},
		{
			ItemType:  "Cookies"
			Name:      1025643
			GroupName: 1044497
			Skill:     50
			NeedOven:  true
			Resources: [
				{
					ItemType: "CookieMix"
					Name:     1044474
					Amount:   1
					Message:  1044253
				},
			]
		},
		{
			ItemType:  "Cake"
			Name:      1022537
			GroupName: 1044497
			Skill:     50
			NeedOven:  true
			Resources: [
				{
					ItemType: "CakeMix"
					Name:     1044471
					Amount:   1
					Message:  1044253
				},
			]
		},
		{
			ItemType:  "Muffins"
			Name:      1022539
			GroupName: 1044497
			Skill:     30
			NeedOven:  true
			Resources: [
				{
					ItemType: "SweetDough"
					Name:     1044475
					Amount:   1
					Message:  1044253
				},
			]
		},
		{
			ItemType:  "Quiche"
			Name:      1041345
			GroupName: 1044497
			Skill:     30
			NeedOven:  true
			Resources: [
				{
					ItemType: "UnbakedQuiche"
					Name:     1044518
					Amount:   1
					Message:  1044253
				},
			]
		},
		{
			ItemType:  "MeatPie"
			Name:      1041347
			GroupName: 1044497
			Skill:     80
			NeedOven:  true
			Resources: [
				{
					ItemType: "UnbakedMeatPie"
					Name:     1044519
					Amount:   1
					Message:  1044253
				},
			]
		},
		{
			ItemType:  "SausagePizza"
			Name:      1044517
			GroupName: 1044497
			Skill:     80
			NeedOven:  true
			Resources: [
				{
					ItemType: "UncookedSausagePizza"
					Name:     1044520
					Amount:   1
					Message:  1044253
				},
			]
		},
		{
			ItemType:  "CheesePizza"
			Name:      1044516
			GroupName: 1044497
			Skill:     50
			NeedOven:  true
			Resources: [
				{
					ItemType: "UncookedCheesePizza"
					Name:     1044521
					Amount:   1
					Message:  1044253
				},
			]
		},
		{
			ItemType:  "FruitPie"
			Name:      1041346
			GroupName: 1044497
			Skill:     60
			NeedOven:  true
			Resources: [
				{
					ItemType: "UnbakedFruitPie"
					Name:     1044522
					Amount:   1
					Message:  1044253
				},
			]
		},
		{
			ItemType:  "PeachCobbler"
			Name:      1041344
			GroupName: 1044497
			Skill:     70
			NeedOven:  true
			Resources: [
				{
					ItemType: "UnbakedPeachCobbler"
					Name:     1044523
					Amount:   1
					Message:  1044253
				},
			]
		},
		{
			ItemType:  "ApplePie"
			Name:      1041343
			GroupName: 1044497
			Skill:     60
			NeedOven:  true
			Resources: [
				{
					ItemType: "UnbakedApplePie"
					Name:     1044524
					Amount:   1
					Message:  1044253
				},
			]
		},
		{
			ItemType:  "PumpkinPie"
			Name:      1041348
			GroupName: 1044497
			Skill:     50
			NeedOven:  true
			Resources: [
				{
					ItemType: "UnbakedPumpkinPie"
					Name:     1046461
					Amount:   1
					Message:  1044253
				},
			]
		},
		{
			ItemType:  "CookedBird"
			Name:      1022487
			GroupName: 1044498
			Skill:     20
			NeedHeat:  true
			UseAllRes: true
			Resources: [
				{
					ItemType: "RawBird"
					Name:     1044470
					Amount:   1
					Message:  1044253
				},
			]
		},
		{
			ItemType:  "ChickenLeg"
			Name:      1025640
			GroupName: 1044498
			Skill:     60
			NeedHeat:  true
			UseAllRes: true
			Resources: [
				{
					ItemType: "RawChickenLeg"
					Name:     1044473
					Amount:   1
					Message:  1044253
				},
			]
		},
		{
			ItemType:  "FishSteak"
			Name:      1022427
			GroupName: 1044498
			Skill:     30
			NeedHeat:  true
			UseAllRes: true
			Resources: [
				{
					ItemType: "RawFishSteak"
					Name:     1044476
					Amount:   1
					Message:  1044253
				},
			]
		},
		{
			ItemType:  "FriedEggs"
			Name:      1022486
			GroupName: 1044498
			Skill:     30
			NeedHeat:  true
			UseAllRes: true
			Resources: [
				{
					ItemType: "Eggs"
					Name:     1044477
					Amount:   1
					Message:  1044253
				},
			]
		},
		{
			ItemType:  "LambLeg"
			Name:      1025642
			GroupName: 1044498
			Skill:     50
			NeedHeat:  true
			UseAllRes: true
			Resources: [
				{
					ItemType: "RawLambLeg"
					Name:     1044478
					Amount:   1
					Message:  1044253
				},
			]
		},
		{
			ItemType:  "Ribs"
			Name:      1022546
			GroupName: 1044498
			Skill:     20
			NeedHeat:  true
			UseAllRes: true
			Resources: [
				{
					ItemType: "RawRibs"
					Name:     1044485
					Amount:   1
					Message:  1044253
				},
			]
		},
	]
}
