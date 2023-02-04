package Crafting

import (
	Types "github.com/zuluhotelaustralia/zuluhotel/Types"
)

Fletching: Types.#CraftSettings & {
	MainSkill:      "Fletching"
	GumpTitleId:    1044006
	MinCraftDelays: 3
	MaxCraftDelays: 3
	Delay:          2.0
	MinCraftChance: 0
	CraftWorkSound: 86
	CraftEndSound:  86
	CraftEntries: [
		{
			ItemType:  "Kindling"
			Name:      1023553
			GroupName: 1044457
			Skill:     0
			Resources: [
				{
					ItemType: "Log"
					Name:     1044041
					Amount:   1
					Message:  1044351
				},
			]
		},
		{
			ItemType:  "Shaft"
			Name:      1027124
			GroupName: 1044457
			Skill:     0
			UseAllRes: true
			Resources: [
				{
					ItemType: "Log"
					Name:     1044041
					Amount:   1
					Message:  1044351
				},
			]
		},
		{
			ItemType:  "Arrow"
			Name:      1023903
			GroupName: 1044565
			Skill:     0
			UseAllRes: true
			Resources: [
				{
					ItemType: "Shaft"
					Name:     1044560
					Amount:   1
					Message:  1044561
				},
				{
					ItemType: "Feather"
					Name:     1044562
					Amount:   1
					Message:  1044563
				},
			]
		},
		{
			ItemType:  "Bolt"
			Name:      1027163
			GroupName: 1044565
			Skill:     0
			UseAllRes: true
			Resources: [
				{
					ItemType: "Shaft"
					Name:     1044560
					Amount:   1
					Message:  1044561
				},
				{
					ItemType: "Feather"
					Name:     1044562
					Amount:   1
					Message:  1044563
				},
			]
		},
		{
			ItemType:  "Bow"
			Name:      1025042
			GroupName: 1044566
			Skill:     30
			Resources: [
				{
					ItemType: "Log"
					Name:     1044041
					Amount:   7
					Message:  1044351
				},
			]
		},
		{
			ItemType:  "Crossbow"
			Name:      1023919
			GroupName: 1044566
			Skill:     60
			Resources: [
				{
					ItemType: "Log"
					Name:     1044041
					Amount:   7
					Message:  1044351
				},
			]
		},
		{
			ItemType:  "HeavyCrossbow"
			Name:      1025117
			GroupName: 1044566
			Skill:     80
			Resources: [
				{
					ItemType: "Log"
					Name:     1044041
					Amount:   10
					Message:  1044351
				},
			]
		},
	]
}
