package Resources

import (
	Types "github.com/zuluhotelaustralia/zuluhotel/Types"
)

Logs: Types.#LogSettings & {

	BankWidth:  1
	BankHeight: 1
	MinTotal:   45
	MaxTotal:   90
	MinRespawn: 10.0
	MaxRespawn: 20.0
	Skill:      "Lumberjacking"
	MaxRange:   2
	MaxChance:  100
	ResourceEffect: {
		Actions: [13]
		Sounds: [318]
		Counts: [4]
		Delay:      1.6
		SoundDelay: 0.9
	}
	Messages: {
		NoResourcesMessage: 500493 // There's not enough wood here to harvest.
		OutOfRangeMessage:  500446 // That is too far away.
		FailMessage:        500495 // You hack at the tree for a while, but fail to produce any useable wood.
		PackFullMessage:    500497 // You can't place any wood into your backpack!
		ToolBrokeMessage:   500499 // You broke your axe.
	}
	Entries: [
		{
			Name:                 ""
			ResourceType:         "Log"
			HarvestSkillRequired: 0.0
			CraftSkillRequired:   0.0
			VeinChance:           0.0
			Hue:                  0
			Quality:              1.0
		},
		{
			Name:                 "Pinetree"
			ResourceType:         "PinetreeLog"
			HarvestSkillRequired: 50.0
			CraftSkillRequired:   15.0
			VeinChance:           105.0
			Hue:                  1132
			Quality:              1.05
		},
		{
			Name:                 "Cherry"
			ResourceType:         "CherryLog"
			HarvestSkillRequired: 55.0
			CraftSkillRequired:   28.0
			VeinChance:           90.0
			Hue:                  5716
			Quality:              1.1
		},
		{
			Name:                 "Oak"
			ResourceType:         "OakLog"
			HarvestSkillRequired: 60.0
			CraftSkillRequired:   39.0
			VeinChance:           81.0
			Hue:                  1045
			Quality:              1.15
		},
		{
			Name:                 "Purple Passion"
			ResourceType:         "PurplePassionLog"
			HarvestSkillRequired: 65.0
			CraftSkillRequired:   50.0
			VeinChance:           73.0
			Hue:                  515
			Quality:              1.2
		},
		{
			Name:                 "Golden Reflections"
			ResourceType:         "GoldenReflectionsLog"
			HarvestSkillRequired: 70.0
			CraftSkillRequired:   59.0
			VeinChance:           73.0
			Hue:                  48
			Quality:              1.25
		},
		{
			Name:                 "Jade"
			ResourceType:         "JadeLog"
			HarvestSkillRequired: 75.0
			CraftSkillRequired:   68.0
			VeinChance:           60.0
			Hue:                  1162
			Quality:              1.3
		},
		{
			Name:                 "Darkwood"
			ResourceType:         "DarkwoodLog"
			HarvestSkillRequired: 75.0
			CraftSkillRequired:   77.0
			VeinChance:           54.0
			Hue:                  1109
			Quality:              1.35
		},
		{
			Name:                 "Stonewood"
			ResourceType:         "StonewoodLog"
			HarvestSkillRequired: 80.0
			CraftSkillRequired:   84.0
			VeinChance:           48.0
			Hue:                  1154
			Quality:              1.4
		},
		{
			Name:                 "Sun"
			ResourceType:         "SunLog"
			HarvestSkillRequired: 85.0
			CraftSkillRequired:   91.0
			VeinChance:           42.0
			Hue:                  1176
			Quality:              1.45
		},
		{
			Name:                 "Swamp"
			ResourceType:         "SwampLog"
			HarvestSkillRequired: 90.0
			CraftSkillRequired:   98.0
			VeinChance:           36.0
			Hue:                  1177
			Quality:              1.5
		},
		{
			Name:                 "Stardust"
			ResourceType:         "StardustLog"
			HarvestSkillRequired: 95.0
			CraftSkillRequired:   105.0
			VeinChance:           30.0
			Hue:                  1161
			Quality:              1.55
		},
		{
			Name:                 "Silverleaf"
			ResourceType:         "SilverleafLog"
			HarvestSkillRequired: 100.0
			CraftSkillRequired:   110.0
			VeinChance:           25.0
			Hue:                  2301
			Quality:              1.6
		},
		{
			Name:                 "Storm Teal"
			ResourceType:         "StormTealLog"
			HarvestSkillRequired: 105.0
			CraftSkillRequired:   114.0
			VeinChance:           20.0
			Hue:                  1346
			Quality:              1.65
		},
		{
			Name:                 "Emerald"
			ResourceType:         "EmeraldLog"
			HarvestSkillRequired: 110.0
			CraftSkillRequired:   118.0
			VeinChance:           15.0
			Hue:                  1159
			Quality:              1.7
		},
		{
			Name:                 "Blood"
			ResourceType:         "BloodLog"
			HarvestSkillRequired: 115.0
			CraftSkillRequired:   122.0
			VeinChance:           11.0
			Hue:                  1645
			Quality:              1.75
		},
		{
			Name:                 "Hardranger"
			ResourceType:         "HardrangerLog"
			HarvestSkillRequired: 65.0
			CraftSkillRequired:   65.0
			VeinChance:           8.0
			Hue:                  1285
			Quality:              1.28
		},
		{
			Name:                 "Crystal"
			ResourceType:         "CrystalLog"
			HarvestSkillRequired: 120.0
			CraftSkillRequired:   125.0
			VeinChance:           7.0
			Hue:                  1170
			Quality:              1.8
		},
		{
			Name:                 "Gauntlet"
			ResourceType:         "GauntletLog"
			HarvestSkillRequired: 95.0
			CraftSkillRequired:   95.0
			VeinChance:           6.0
			Hue:                  1284
			Quality:              1.48
		},
		{
			Name:                 "Doom"
			ResourceType:         "DoomLog"
			HarvestSkillRequired: 125.0
			CraftSkillRequired:   128.0
			VeinChance:           5.0
			Hue:                  1183
			Quality:              1.9
		},
		{
			Name:                 "Bloodhorse"
			ResourceType:         "BloodhorseLog"
			HarvestSkillRequired: 127.0
			CraftSkillRequired:   127.0
			VeinChance:           4.0
			Hue:                  1287
			Quality:              1.82
		},
		{
			Name:                 "Zulu"
			ResourceType:         "ZuluLog"
			HarvestSkillRequired: 130.0
			CraftSkillRequired:   130.0
			VeinChance:           3.0
			Hue:                  1160
			Quality:              2.0
		},
		{
			Name:                 "Darkness"
			ResourceType:         "DarknessLog"
			HarvestSkillRequired: 140.0
			CraftSkillRequired:   140.0
			VeinChance:           2.0
			Hue:                  1157
			Quality:              2.05
		},
		{
			Name:                 "Elven"
			ResourceType:         "ElvenLog"
			HarvestSkillRequired: 145.0
			CraftSkillRequired:   145.0
			VeinChance:           1.0
			Hue:                  1165
			Quality:              2.1
		},
		{
			Name:                 "Young Oak"
			ResourceType:         "YoungOakLog"
			HarvestSkillRequired: 0.0
			CraftSkillRequired:   100.0
			VeinChance:           0.0
			Hue:                  767
			Quality:              1.0
		},
	]
}
