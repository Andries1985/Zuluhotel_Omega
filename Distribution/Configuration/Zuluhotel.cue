import (
	Creatures "github.com/zuluhotelaustralia/zuluhotel/Creatures"
	Crafting "github.com/zuluhotelaustralia/zuluhotel/Crafting"
	Resources "github.com/zuluhotelaustralia/zuluhotel/Resources"
	Loot "github.com/zuluhotelaustralia/zuluhotel/Loot"
	Magic "github.com/zuluhotelaustralia/zuluhotel/Magic"
	Skills "github.com/zuluhotelaustralia/zuluhotel/Skills"

	Types "github.com/zuluhotelaustralia/zuluhotel/Types"
)

Core: Types.#CoreConfiguration & {
	Expansion:        "T2A"
	InsuranceEnabled: false
	ActionDelay:      500
}

Messaging: Types.#MessagingConfiguration & {
	SuccessHue:             55
	FailureHue:             33
	VisibleDamage:          true
	StaffRevealMagicItems:  true
	ObjectPropertyList:     false
	GuildClickMessage:      false
	AsciiClickMessage:      false
	SingleClickProps:       false
	RewriteMessagesToAscii: true
}

Email: Types.#EmailConfiguration & {
	Enabled:              false
	FromAddress:          "support@modernuo.com"
	FromName:             "ModernUO Team"
	CrashAddress:         "crashes@modernuo.com"
	CrashName:            "Crash Log"
	SpeechLogPageAddress: "support@modernuo.com"
	SpeechLogPageName:    "GM Support Conversation"
	EmailServer:          "smtp.gmail.com"
	EmailPort:            465
	EmailUsername:        "support@modernuo.com"
	EmailPassword:        "Some Password 123"
	EmailSendRetryCount:  5
	EmailSendRetryDelay:  3
}

Creatures: {
	Entries: Creatures
}

Loot: {
	Loot
}

Crafting: {
	Crafting
}

Resources: {
	Resources
}

Magic: {
	Magic
}

Skills: {
	Skills
}
