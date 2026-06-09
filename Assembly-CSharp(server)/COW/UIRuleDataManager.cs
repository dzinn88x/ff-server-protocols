using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02002038 RID: 8248
	[Token(Token = "0x2002038")]
	public static class UIRuleDataManager
	{
		// Token: 0x0600B7D9 RID: 47065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B7D9")]
		[Address(RVA = "0x1A24830", Offset = "0x1A24830", VA = "0x7BBC224830")]
		public static List<RuleMapping> RulesOfType(RuleType ruleType, object extralData)
		{
			return null;
		}

		// Token: 0x0400B9EC RID: 47596
		[Token(Token = "0x400B9EC")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string RULE_CHEST_RULE_TILTE;

		// Token: 0x0400B9ED RID: 47597
		[Token(Token = "0x400B9ED")]
		[FieldOffset(Offset = "0x8")]
		public static readonly string RULE_CHEST_RULE_INFO2;

		// Token: 0x0400B9EE RID: 47598
		[Token(Token = "0x400B9EE")]
		[FieldOffset(Offset = "0x10")]
		public static readonly string RULE_CHEST_WHEEL_HELP_TAB;

		// Token: 0x0400B9EF RID: 47599
		[Token(Token = "0x400B9EF")]
		[FieldOffset(Offset = "0x18")]
		public static readonly string RULE_CHEST_WHEEL_HELP_DESC;

		// Token: 0x0400B9F0 RID: 47600
		[Token(Token = "0x400B9F0")]
		[FieldOffset(Offset = "0x20")]
		public static readonly string RULE_CHEST_LEGEND_HELP_TAB;

		// Token: 0x0400B9F1 RID: 47601
		[Token(Token = "0x400B9F1")]
		[FieldOffset(Offset = "0x28")]
		public static readonly string RULE_CHEST_LEGEND_HELP_DESC;

		// Token: 0x0400B9F2 RID: 47602
		[Token(Token = "0x400B9F2")]
		[FieldOffset(Offset = "0x30")]
		public static readonly string RULE_CHEST_FADED_HELP_TAB;

		// Token: 0x0400B9F3 RID: 47603
		[Token(Token = "0x400B9F3")]
		[FieldOffset(Offset = "0x38")]
		public static readonly string RULE_CHEST_FADED_HELP_DESC;

		// Token: 0x0400B9F4 RID: 47604
		[Token(Token = "0x400B9F4")]
		[FieldOffset(Offset = "0x40")]
		public static readonly string RULE_CS_CLAN_RULE;

		// Token: 0x0400B9F5 RID: 47605
		[Token(Token = "0x400B9F5")]
		[FieldOffset(Offset = "0x48")]
		public static readonly string RULE_CLAN_TITLE_05;

		// Token: 0x0400B9F6 RID: 47606
		[Token(Token = "0x400B9F6")]
		[FieldOffset(Offset = "0x50")]
		public static readonly string RULE_INTEGRATE_MAIN;

		// Token: 0x0400B9F7 RID: 47607
		[Token(Token = "0x400B9F7")]
		[FieldOffset(Offset = "0x58")]
		public static readonly string RULE_INTEGRATE_ACTIVITY;

		// Token: 0x0400B9F8 RID: 47608
		[Token(Token = "0x400B9F8")]
		[FieldOffset(Offset = "0x60")]
		public static readonly string RULE_INTEGRATE_LOGINREWARD;

		// Token: 0x0400B9F9 RID: 47609
		[Token(Token = "0x400B9F9")]
		[FieldOffset(Offset = "0x68")]
		public static readonly string RULE_INTEGRATE_GACHA;

		// Token: 0x0400B9FA RID: 47610
		[Token(Token = "0x400B9FA")]
		[FieldOffset(Offset = "0x70")]
		public static readonly string RULE_INTEGRATE_TURNTABLE;

		// Token: 0x0400B9FB RID: 47611
		[Token(Token = "0x400B9FB")]
		[FieldOffset(Offset = "0x78")]
		public static readonly string RULE_RAMPAGE_TURNTABLE;

		// Token: 0x0400B9FC RID: 47612
		[Token(Token = "0x400B9FC")]
		[FieldOffset(Offset = "0x80")]
		public static readonly string RULE_MYSTERYMALL;

		// Token: 0x0400B9FD RID: 47613
		[Token(Token = "0x400B9FD")]
		[FieldOffset(Offset = "0x88")]
		public static readonly string RULE_BOUNTY;

		// Token: 0x0400B9FE RID: 47614
		[Token(Token = "0x400B9FE")]
		[FieldOffset(Offset = "0x90")]
		public static readonly string RULE_MVP;

		// Token: 0x0400B9FF RID: 47615
		[Token(Token = "0x400B9FF")]
		[FieldOffset(Offset = "0x98")]
		public static readonly string RULE_GOLIATH;

		// Token: 0x0400BA00 RID: 47616
		[Token(Token = "0x400BA00")]
		[FieldOffset(Offset = "0xA0")]
		public static readonly string RULE_WEAPON_RACK;

		// Token: 0x0400BA01 RID: 47617
		[Token(Token = "0x400BA01")]
		[FieldOffset(Offset = "0xA8")]
		public static readonly string RULE_FFWS;

		// Token: 0x0400BA02 RID: 47618
		[Token(Token = "0x400BA02")]
		[FieldOffset(Offset = "0xB0")]
		public static readonly string RULE_SUPERCAR;

		// Token: 0x0400BA03 RID: 47619
		[Token(Token = "0x400BA03")]
		[FieldOffset(Offset = "0xB8")]
		private static Dictionary<RuleType, List<RuleMapping>> m_RuleDic;
	}
}
