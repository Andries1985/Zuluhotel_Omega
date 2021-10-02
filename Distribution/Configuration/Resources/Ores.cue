package Resources

import (
	Types "github.com/zuluhotelaustralia/zuluhotel/Types"
)

Ores: Types.#OreSettings & {

	BankWidth:  1
	BankHeight: 1
	MinTotal:   45
	MaxTotal:   90
	MinRespawn: 10.0
	MaxRespawn: 20.0
	Skill:      "Mining"
	MaxRange:   2
	MaxChance:  155
	ResourceEffect: {
		Actions: [11]
		Sounds: [66]
		Counts: [4]
		Delay:      1.6
		SoundDelay: 0.9
	}
	Messages: {
		NoResourcesMessage:     503040  // There is no metal here to mine.
		DoubleHarvestMessage:   503042  // Someone has gotten to the metal before you.
		TimedOutOfRangeMessage: 503041  // You have moved too far away to continue mining.
		OutOfRangeMessage:      500446  // That is too far away.
		FailMessage:            503043  // You loosen some rocks but fail to find any useable ore.
		PackFullMessage:        1010481 // Your backpack is full, so the ore you mined is lost.
		ToolBrokeMessage:       1044038 // You have worn out your tool!
	}
	Entries: [
		{
			Name:                 "Iron"
			ResourceType:         "IronOre"
			SmeltType:            "IronIngot"
			HarvestSkillRequired: 0.0
			SmeltSkillRequired:   10.0
			CraftSkillRequired:   0.0
			VeinChance:           0.0
			Hue:                  0
			Quality:              1.0
			Enchantments: []
		},
		{
			Name:                 "Spike"
			ResourceType:         "SpikeOre"
			SmeltType:            "SpikeIngot"
			HarvestSkillRequired: 15.0
			SmeltSkillRequired:   15.0
			CraftSkillRequired:   5.0
			VeinChance:           155.0
			Hue:                  1223
			Quality:              1.05
			Enchantments: []
		},
		{
			Name:                 "Fruity"
			ResourceType:         "FruityOre"
			SmeltType:            "FruityIngot"
			HarvestSkillRequired: 20.0
			SmeltSkillRequired:   20.0
			CraftSkillRequired:   10.0
			VeinChance:           140.0
			Hue:                  1134
			Quality:              1.05
			Enchantments: [
				{
					EnchantmentType:  "DexBonus"
					EnchantmentValue: 1
				},
			]
		},
		{
			Name:                 "Ice Rock"
			ResourceType:         "IceRockOre"
			SmeltType:            "IceRockIngot"
			HarvestSkillRequired: 25.0
			SmeltSkillRequired:   25.0
			CraftSkillRequired:   20.0
			VeinChance:           130.0
			Hue:                  1152
			Quality:              1.05
			Enchantments: [
				{
					EnchantmentType:  "WaterProtection"
					EnchantmentValue: 25
				},
			]
		},
		{
			Name:                 "Black Dwarf"
			ResourceType:         "BlackDwarfOre"
			SmeltType:            "BlackDwarfIngot"
			HarvestSkillRequired: 25.0
			SmeltSkillRequired:   30.0
			CraftSkillRequired:   25.0
			VeinChance:           125.0
			Hue:                  1105
			Quality:              1.1
			Enchantments: []
		},
		{
			Name:                 "Bronze"
			ResourceType:         "BronzeOre"
			SmeltType:            "BronzeIngot"
			HarvestSkillRequired: 35.0
			SmeltSkillRequired:   35.0
			CraftSkillRequired:   15.0
			VeinChance:           120.0
			Hue:                  1118
			Quality:              1.1
			Enchantments: []
		},
		{
			Name:                 "Dark Pagan"
			ResourceType:         "DarkPaganOre"
			SmeltType:            "DarkPaganIngot"
			HarvestSkillRequired: 40.0
			SmeltSkillRequired:   40.0
			CraftSkillRequired:   25.0
			VeinChance:           110.0
			Hue:                  1131
			Quality:              1.1
			Enchantments: []
		},
		{
			Name:                 "Silver Rock"
			ResourceType:         "SilverRockOre"
			SmeltType:            "SilverRockIngot"
			HarvestSkillRequired: 45.0
			SmeltSkillRequired:   45.0
			CraftSkillRequired:   40.0
			VeinChance:           100.0
			Hue:                  1001
			Quality:              1.1
			Enchantments: [
				{
					EnchantmentType:  "NecroProtection"
					EnchantmentValue: 25
				},
			]
		},
		{
			Name:                 "Platinum"
			ResourceType:         "PlatinumOre"
			SmeltType:            "PlatinumIngot"
			HarvestSkillRequired: 50.0
			SmeltSkillRequired:   50.0
			CraftSkillRequired:   35.0
			VeinChance:           90.0
			Hue:                  1111
			Quality:              1.15
			Enchantments: [
				{
					EnchantmentType:  "MagicEfficiencyPenalty"
					EnchantmentValue: -1
				},
			]
		},
		{
			Name:                 "Dull Copper"
			ResourceType:         "DullCopperOre"
			SmeltType:            "DullCopperIngot"
			HarvestSkillRequired: 55.0
			SmeltSkillRequired:   55.0
			CraftSkillRequired:   30.0
			VeinChance:           85.0
			Hue:                  1002
			Quality:              1.15
			Enchantments: []
		},
		{
			Name:                 "Mystic"
			ResourceType:         "MysticOre"
			SmeltType:            "MysticIngot"
			HarvestSkillRequired: 60.0
			SmeltSkillRequired:   60.0
			CraftSkillRequired:   55.0
			VeinChance:           80.0
			Hue:                  383
			Quality:              1.05
			Enchantments: [
				{
					EnchantmentType:  "MagicEfficiencyPenalty"
					EnchantmentValue: -3
				},
			]
		},
		{
			Name:                 "Copper"
			ResourceType:         "CopperOre"
			SmeltType:            "CopperIngot"
			HarvestSkillRequired: 65.0
			SmeltSkillRequired:   65.0
			CraftSkillRequired:   50.0
			VeinChance:           74.0
			Hue:                  1538
			Quality:              1.2
			Enchantments: []
		},
		{
			Name:                 "Spectral"
			ResourceType:         "SpectralOre"
			SmeltType:            "SpectralIngot"
			HarvestSkillRequired: 70.0
			SmeltSkillRequired:   70.0
			CraftSkillRequired:   60.0
			VeinChance:           71.0
			Hue:                  1155
			Quality:              1.1
			Enchantments: [
				{
					EnchantmentType:  "DexBonus"
					EnchantmentValue: 3
				},
			]
		},
		{
			Name:                 "Onyx"
			ResourceType:         "OnyxOre"
			SmeltType:            "OnyxIngot"
			HarvestSkillRequired: 75.0
			SmeltSkillRequired:   75.0
			CraftSkillRequired:   70.0
			VeinChance:           66.0
			Hue:                  1109
			Quality:              1.25
			Enchantments: [
				{
					EnchantmentType:  "DexBonus"
					EnchantmentValue: 1
				},
			]
		},
		{
			Name:                 "Old Britain"
			ResourceType:         "OldBritainOre"
			SmeltType:            "OldBritainIngot"
			HarvestSkillRequired: 80.0
			SmeltSkillRequired:   80.0
			CraftSkillRequired:   65.0
			VeinChance:           61.0
			Hue:                  2130
			Quality:              1.25
			Enchantments: []
		},
		{
			Name:                 "Red Elven"
			ResourceType:         "RedElvenOre"
			SmeltType:            "RedElvenIngot"
			HarvestSkillRequired: 84.0
			SmeltSkillRequired:   84.0
			CraftSkillRequired:   75.0
			VeinChance:           56.0
			Hue:                  1209
			Quality:              1.15
			Enchantments: [
				{
					EnchantmentType:  "DexBonus"
					EnchantmentValue: 2
				},
				{
					EnchantmentType:  "MagicEfficiencyPenalty"
					EnchantmentValue: -1
				},
			]
		},
		{
			Name:                 "Undead"
			ResourceType:         "UndeadOre"
			SmeltType:            "UndeadIngot"
			HarvestSkillRequired: 88.0
			SmeltSkillRequired:   88.0
			CraftSkillRequired:   80.0
			VeinChance:           51.0
			Hue:                  633
			Quality:              1.2
			Enchantments: [
				{
					EnchantmentType:  "NecroProtection"
					EnchantmentValue: 50
				},
			]
		},
		{
			Name:                 "Pyrite"
			ResourceType:         "PyriteOre"
			SmeltType:            "PyriteIngot"
			HarvestSkillRequired: 91.0
			SmeltSkillRequired:   91.0
			CraftSkillRequired:   85.0
			VeinChance:           46.0
			Hue:                  1720
			Quality:              1.3
			Enchantments: [
				{
					EnchantmentType:  "DexBonus"
					EnchantmentValue: 1
				},
			]
		},
		{
			Name:                 "Virginity"
			ResourceType:         "VirginityOre"
			SmeltType:            "VirginityIngot"
			HarvestSkillRequired: 94.0
			SmeltSkillRequired:   94.0
			CraftSkillRequired:   90.0
			VeinChance:           42.0
			Hue:                  1154
			Quality:              1.25
			Enchantments: [
				{
					EnchantmentType:  "DexBonus"
					EnchantmentValue: 1
				},
				{
					EnchantmentType:  "NecroProtection"
					EnchantmentValue: 25
				},
			]
		},
		{
			Name:                 "Malachite"
			ResourceType:         "MalachiteOre"
			SmeltType:            "MalachiteIngot"
			HarvestSkillRequired: 95.0
			SmeltSkillRequired:   95.0
			CraftSkillRequired:   95.0
			VeinChance:           38.0
			Hue:                  1159
			Quality:              1.5
			Enchantments: []
		},
		{
			Name:                 "Lava Rock"
			ResourceType:         "LavaRockOre"
			SmeltType:            "LavaRockIngot"
			HarvestSkillRequired: 97.0
			SmeltSkillRequired:   97.0
			CraftSkillRequired:   97.0
			VeinChance:           33.0
			Hue:                  1158
			Quality:              1.35
			Enchantments: [
				{
					EnchantmentType:  "FireProtection"
					EnchantmentValue: 50
				},
			]
		},
		{
			Name:                 "Azurite"
			ResourceType:         "AzuriteOre"
			SmeltType:            "AzuriteIngot"
			HarvestSkillRequired: 105.0
			SmeltSkillRequired:   98.0
			CraftSkillRequired:   98.0
			VeinChance:           26.0
			Hue:                  1247
			Quality:              1.4
			Enchantments: [
				{
					EnchantmentType:  "DexBonus"
					EnchantmentValue: 1
				},
				{
					EnchantmentType:  "AirProtection"
					EnchantmentValue: 50
				},
			]
		},
		{
			Name:                 "Dripstone"
			ResourceType:         "DripstoneOre"
			SmeltType:            "DripstoneIngot"
			HarvestSkillRequired: 120.0
			SmeltSkillRequired:   100.0
			CraftSkillRequired:   100.0
			VeinChance:           23.0
			Hue:                  1182
			Quality:              1.45
			Enchantments: [
				{
					EnchantmentType:  "MagicEfficiencyPenalty"
					EnchantmentValue: -1
				},
				{
					EnchantmentType:  "WaterProtection"
					EnchantmentValue: 25
				},
			]
		},
		{
			Name:                 "Executor"
			ResourceType:         "ExecutorOre"
			SmeltType:            "ExecutorIngot"
			HarvestSkillRequired: 120.0
			SmeltSkillRequired:   103.0
			CraftSkillRequired:   104.0
			VeinChance:           20.0
			Hue:                  1177
			Quality:              1.45
			Enchantments: [
				{
					EnchantmentType:  "MagicEfficiencyPenalty"
					EnchantmentValue: -2
				},
			]
		},
		{
			Name:                 "Peachblue"
			ResourceType:         "PeachblueOre"
			SmeltType:            "PeachblueIngot"
			HarvestSkillRequired: 120.0
			SmeltSkillRequired:   106.0
			CraftSkillRequired:   108.0
			VeinChance:           17.0
			Hue:                  1180
			Quality:              1.55
			Enchantments: [
				{
					EnchantmentType:  "DexBonus"
					EnchantmentValue: 2
				},
			]
		},
		{
			Name:                 "Destruction"
			ResourceType:         "DestructionOre"
			SmeltType:            "DestructionIngot"
			HarvestSkillRequired: 120.0
			SmeltSkillRequired:   109.0
			CraftSkillRequired:   112.0
			VeinChance:           14.0
			Hue:                  1280
			Quality:              1.55
			Enchantments: [
				{
					EnchantmentType:  "DexBonus"
					EnchantmentValue: 1
				},
				{
					EnchantmentType:  "EarthProtection"
					EnchantmentValue: 25
				},
			]
		},
		{
			Name:                 "Anra"
			ResourceType:         "AnraOre"
			SmeltType:            "AnraIngot"
			HarvestSkillRequired: 120.0
			SmeltSkillRequired:   112.0
			CraftSkillRequired:   116.0
			VeinChance:           10.0
			Hue:                  1163
			Quality:              1.65
			Enchantments: [
				{
					EnchantmentType:  "DexBonus"
					EnchantmentValue: 2
				},
			]
		},
		{
			Name:                 "Crystal"
			ResourceType:         "CrystalOre"
			SmeltType:            "CrystalIngot"
			HarvestSkillRequired: 120.0
			SmeltSkillRequired:   115.0
			CraftSkillRequired:   119.0
			VeinChance:           8.0
			Hue:                  1170
			Quality:              1.65
			Enchantments: [
				{
					EnchantmentType:  "MagicEfficiencyPenalty"
					EnchantmentValue: -3
				},
				{
					EnchantmentType:  "EarthProtection"
					EnchantmentValue: 25
				},
			]
		},
		{
			Name:                 "Doom"
			ResourceType:         "DoomOre"
			SmeltType:            "DoomIngot"
			HarvestSkillRequired: 125.0
			SmeltSkillRequired:   118.0
			CraftSkillRequired:   122.0
			VeinChance:           5.0
			Hue:                  1183
			Quality:              1.75
			Enchantments: []
		},
		{
			Name:                 "Goddess"
			ResourceType:         "GoddessOre"
			SmeltType:            "GoddessIngot"
			HarvestSkillRequired: 130.0
			SmeltSkillRequired:   121.0
			CraftSkillRequired:   125.0
			VeinChance:           2.0
			Hue:                  1281
			Quality:              1.75
			Enchantments: [
				{
					EnchantmentType:  "MagicEfficiencyPenalty"
					EnchantmentValue: -2
				},
				{
					EnchantmentType:  "AirProtection"
					EnchantmentValue: 25
				},
			]
		},
		{
			Name:                 "New Zulu"
			ResourceType:         "NewZuluOre"
			SmeltType:            "NewZuluIngot"
			HarvestSkillRequired: 0.0
			SmeltSkillRequired:   125.0
			CraftSkillRequired:   129.0
			VeinChance:           0.0
			Hue:                  1160
			Quality:              1.8
			Enchantments: [
				{
					EnchantmentType:  "MagicEfficiencyPenalty"
					EnchantmentValue: -3
				},
				{
					EnchantmentType:  "DexBonus"
					EnchantmentValue: 2
				},
			]
		},
		{
			Name:                 "Ebon Twilight Sapphire"
			ResourceType:         "EbonTwilightSapphireOre"
			SmeltType:            "EbonTwilightSapphireIngot"
			HarvestSkillRequired: 0.0
			SmeltSkillRequired:   125.0
			CraftSkillRequired:   130.0
			VeinChance:           0.0
			Hue:                  1171
			Quality:              2.2
			Enchantments: [
				{
					EnchantmentType:  "MagicEfficiencyPenalty"
					EnchantmentValue: -3
				},
				{
					EnchantmentType:  "DexBonus"
					EnchantmentValue: 3
				},
				{
					EnchantmentType:  "MagicImmunity"
					EnchantmentValue: 2
				},
				{
					EnchantmentType:  "WaterProtection"
					EnchantmentValue: 75
				},
			]
		},
		{
			Name:                 "Dark Sable Ruby"
			ResourceType:         "DarkSableRubyOre"
			SmeltType:            "DarkSableRubyIngot"
			HarvestSkillRequired: 0.0
			SmeltSkillRequired:   125.0
			CraftSkillRequired:   130.0
			VeinChance:           0.0
			Hue:                  1172
			Quality:              2.2
			Enchantments: [
				{
					EnchantmentType:  "MagicEfficiencyPenalty"
					EnchantmentValue: -3
				},
				{
					EnchantmentType:  "DexBonus"
					EnchantmentValue: 3
				},
				{
					EnchantmentType:  "MagicImmunity"
					EnchantmentValue: 2
				},
				{
					EnchantmentType:  "FireProtection"
					EnchantmentValue: 75
				},
			]
		},
		{
			Name:                 "Radiant Nimbus Diamond"
			ResourceType:         "RadiantNimbusDiamondOre"
			SmeltType:            "RadiantNimbusDiamondIngot"
			HarvestSkillRequired: 0.0
			SmeltSkillRequired:   125.0
			CraftSkillRequired:   140.0
			VeinChance:           0.0
			Hue:                  1176
			Quality:              2.25
			Enchantments: [
				{
					EnchantmentType:  "MagicEfficiencyPenalty"
					EnchantmentValue: -3
				},
				{
					EnchantmentType:  "DexBonus"
					EnchantmentValue: 3
				},
				{
					EnchantmentType:  "MagicImmunity"
					EnchantmentValue: 4
				},
				{
					EnchantmentType:  "NecroProtection"
					EnchantmentValue: 75
				},
				{
					EnchantmentType:  "EarthProtection"
					EnchantmentValue: 75
				},
				{
					EnchantmentType:  "AirProtection"
					EnchantmentValue: 75
				},
			]
		},
	]
}
