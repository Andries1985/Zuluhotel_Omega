package Animal

CelestialOstard: {
	BaseType:             "BaseMount"
	Name:                 "Celestial Ostard"
	CorpseNameOverride:   "corpse of Celestial Ostard"
	Str:                  650
	Int:                  400
	Dex:                  300
	AiType:               "AI_Healer"
	AutoDispel:           true
	BaseSoundID:          629
	Body:                 218
	ItemID:				  16037
	CanFly:               true
	CreatureType:         "Animal"
	FightMode:            "Aggressor"
	VirtualArmor:         50
	HitsMaxSeed:          650
	Hue:                  1176
	InitialInnocent:      true
	AlwaysAttackable:	  false
	ManaMaxSeed:          200
	MinTameSkill:         115
	ProvokeSkillOverride: 150
	StamMaxSeed:          175
	Tamable:              true
	Resistances: {
		Poison:        6
		Air:           50
		Water:         50
		Fire:          50
		Necro:         50
		Earth:         100
		MagicImmunity: 5
	}
	Skills: {
		MagicResist:  110
		Tactics:      100
		Wrestling:    140
		DetectHidden: 130
		Magery:       200
	}
	Attack: {
		Speed: 60
		Damage: {
			Min: 25
			Max: 75
		}
		HitSound: 362
	}
}
