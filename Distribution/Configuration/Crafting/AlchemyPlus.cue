package Crafting

import (
	Types "github.com/zuluhotelaustralia/zuluhotel/Types"
)

AlchemyPlus: Types.#CraftSettings & {
	MainSkill:      "Alchemy"
	GumpTitleId:    1044001
	MinCraftDelays: 4
	MaxCraftDelays: 4
	Delay:          1.0
	MinCraftChance: 0.0
	CraftWorkSound: 550
	CraftEndSound:  549
	CraftEntries: [
		{
			ItemType:  "PhandelsFineIntellectPotion"
			Name:      "Phandel's Fine Intellect"
			GroupName: 3000112
			Skill:     30
			Resources: [
				{
					ItemType: "FertileDirt"
					Name:     1023969
					Amount:   1
					Message:  "You do not have enough Fertile Dirt to make that."
				},
				{
					Amount:   1
					ItemType: "VolcanicAsh"
					Name:     "Volcanic Ash"
					Message:  "You do not have enough Volcanic Ash to make that."
				},
				{
					ItemType: "Bottle"
					Name:     1044529
					Amount:   1
					Message:  500315
				},
			]
		},
		{
			ItemType:  "PhandelsFabulousIntellectPotion"
			Name:      "Phandel's Fabulous Intellect"
			GroupName: 3000112
			Skill:     60
			Resources: [
				{
					ItemType: "FertileDirt"
					Name:     1023969
					Amount:   2
					Message:  "You do not have enough Fertile Dirt to make that."
				},
				{
					Amount:   3
					ItemType: "VolcanicAsh"
					Name:     "Volcanic Ash"
					Message:  "You do not have enough Volcanic Ash to make that."
				},
				{
					ItemType: "Bottle"
					Name:     1044529
					Amount:   1
					Message:  500315
				},
			]
		},
		{
			ItemType:  "PhandelsFantasticIntellectPotion"
			Name:      "Phandel's Fantastic Intellect"
			GroupName: 3000112
			Skill:     80
			Resources: [
				{
					ItemType: "FertileDirt"
					Name:     1023969
					Amount:   5
					Message:  "You do not have enough Fertile Dirt to make that."
				},
				{
					Amount:   7
					ItemType: "VolcanicAsh"
					Name:     "Volcanic Ash"
					Message:  "You do not have enough Volcanic Ash to make that."
				},
				{
					ItemType: "Bottle"
					Name:     1044529
					Amount:   1
					Message:  500315
				},
			]
		},
		{
			ItemType:  "LesserMegoInvulnerabilityPotion"
			Name:      "lesser Mego Invulnerability potion"
			GroupName: 3002025
			Skill:     30
			Resources: [
				{
					ItemType: "SerpentScale"
					Name:     "Serpent's Scale"
					Amount:   1
					Message:  "You do not have enough Serpent's Scales to make that."
				},
				{
					ItemType: "Ginseng"
					Name:     1044356
					Amount:   1
					Message:  1044364
				},
				{
					ItemType: "Bottle"
					Name:     1044529
					Amount:   1
					Message:  500315
				},
			]
		},
		{
			ItemType:  "MegoInvulnerabilityPotion"
			Name:      "Mego Invulnerability potion"
			GroupName: 3002025
			Skill:     50
			Resources: [
				{
					ItemType: "SerpentScale"
					Name:     "Serpent's Scale"
					Amount:   4
					Message:  "You do not have enough Serpent's Scales to make that."
				},
				{
					ItemType: "Ginseng"
					Name:     1044356
					Amount:   3
					Message:  1044364
				},
				{
					ItemType: "Bottle"
					Name:     1044529
					Amount:   1
					Message:  500315
				},
			]
		},
		{
			ItemType:  "GreaterMegoInvulnerabilityPotion"
			Name:      "greater Mego Invulnerability potion"
			GroupName: 3002025
			Skill:     80
			Resources: [
				{
					ItemType: "SerpentScale"
					Name:     "Serpent's Scale"
					Amount:   6
					Message:  "You do not have enough Serpent's Scale to make that."
				},
				{
					ItemType: "Ginseng"
					Name:     1044356
					Amount:   5
					Message:  1044364
				},
				{
					ItemType: "Bottle"
					Name:     1044529
					Amount:   1
					Message:  500315
				},
			]
		},
		{
			ItemType:  "GrandMageRefreshElixir"
			Name:      "Grand Mage Refresh Elixir"
			GroupName: 1075867
			Skill:     120
			Resources: [
				{
					ItemType: "Blackmoor"
					Name:     1023961
					Amount:   15
					Message:  "You do not have enough Blackmoor to make that."
				},
				{
					ItemType: "Amethyst"
					Name:     1023862
					Amount:   3
					Message:  1044240
				},
				{
					ItemType: "Bottle"
					Name:     1044529
					Amount:   1
					Message:  500315
				},
			]
		},
		{
			ItemType:  "HomericMightPotion"
			Name:      "Homeric Might potion"
			GroupName: 1044397
			Skill:     40
			Resources: [
				{
					ItemType: "DragonsBlood"
					Name:     1023970
					Amount:   1
					Message:  "You do not have enough Dragon's Blood to make that."
				},
				{
					ItemType: "GreaterStrengthPotion"
					Name:     1041321
					Amount:   1
					Message:  "You do not have enough Greater Strength potions to make that."
				},
				{
					ItemType: "Bottle"
					Name:     1044529
					Amount:   1
					Message:  500315
				},
			]
		},
		{
			ItemType:  "GreaterHomericMightPotion"
			Name:      "Greater Homeric Might potion"
			GroupName: 1044397
			Skill:     75
			Resources: [
				{
					ItemType: "DragonsBlood"
					Name:     1023970
					Amount:   4
					Message:  "You do not have enough Dragon's Blood to make that."
				},
				{
					ItemType: "GreaterStrengthPotion"
					Name:     1041321
					Amount:   1
					Message:  "You do not have enough Greater Strength potions to make that."
				},
				{
					ItemType: "Bottle"
					Name:     1044529
					Amount:   1
					Message:  500315
				},
			]
		},
		{
			ItemType:  "TamlaHealPotion"
			Name:      "Tamla Heal potion"
			GroupName: 1075867
			Skill:     115
			Resources: [
				{
					ItemType: "GreaterHealPotion"
					Name:     1073467
					Amount:   1
					Message:  "You do not have enough Greater Heal potions to make that."
				},
				{
					ItemType: "StarSapphire"
					Name:     1023855
					Amount:   3
					Message:  1044240
				},
				{
					ItemType: "WyrmsHeart"
					Name:     1023985
					Amount:   3
					Message:  "You do not have enough Wyrm's Hearts to make that."
				},
				{
					ItemType: "DragonsBlood"
					Name:     1023970
					Amount:   2
					Message:  "You do not have enough Dragon's Blood to make that."
				},
			]
		},
		{
			ItemType:  "TaintsTransmutationPotion"
			Name:      "Taint's Minor Transmutation"
			GroupName: 1075824
			Skill:     70
			Resources: [
				{
					ItemType: "FertileDirt"
					Name:     1023969
					Amount:   2
					Message:  "You do not have enough Fertile Dirt to make that."
				},
				{
					ItemType: "DeadWood"
					Name:     1023984
					Amount:   2
					Message:  "You do not have enough Dead Wood to make that."
				},
				{
					ItemType: "Bottle"
					Name:     1044529
					Amount:   1
					Message:  500315
				},
			]
		},
		{
			ItemType:  "TaintsMajorTransmutationPotion"
			Name:      "Taint's Major Transmutation"
			GroupName: 1075824
			Skill:     90
			Resources: [
				{
					ItemType: "FertileDirt"
					Name:     1023969
					Amount:   5
					Message:  "You do not have enough Fertile Dirt to make that."
				},
				{
					ItemType: "DeadWood"
					Name:     1023984
					Amount:   3
					Message:  "You do not have enough Dead Wood to make that."
				},
				{
					ItemType: "Bottle"
					Name:     1044529
					Amount:   1
					Message:  500315
				},
			]
		},
		{
			ItemType:  "Totem"
			Name:      "Totem"
			GroupName: 1061664
			Skill:     130
			Resources: [
				{
					ItemType: "BatWing"
					Name:     1023960
					Amount:   2
					Message:  "You do not have enough Bat Wings to make that."
				},
				{
					ItemType: "DaemonBone"
					Name:     1017412
					Amount:   5
					Message:  "You do not have enough Daemon Bones to make that."
				},
				{
					ItemType: "TrollHide"
					Name:     "Troll Hides"
					Amount:   6
					Message:  "You do not have enough Troll Hides to make that."
				},
			]
		},
		{
			ItemType:  "TotemElixir"
			Name:      "Elixir"
			GroupName: 1061664
			Skill:     130
			Resources: [
				{
					ItemType: "WyrmsHeart"
					Name:     1023985
					Amount:   3
					Message:  "You do not have enough Wyrm's Hearts to make that."
				},
				{
					ItemType: "Diamond"
					Name:     1023878
					Amount:   1
					Message:  1044240
				},
				{
					ItemType: "Bottle"
					Name:     1044529
					Amount:   1
					Message:  500315
				},
			]
		},
	]
}
