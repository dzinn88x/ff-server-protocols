using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000671 RID: 1649
	[Token(Token = "0x2000671")]
	[ProtoContract]
	public class EChampionship
	{
		// Token: 0x060023BE RID: 9150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023BE")]
		[Address(RVA = "0x21B97E8", Offset = "0x21B97E8", VA = "0x7BBC9B97E8")]
		public EChampionship()
		{
		}

		// Token: 0x02000672 RID: 1650
		[Token(Token = "0x2000672")]
		[ProtoContract]
		public enum MemberType
		{
			// Token: 0x0400207D RID: 8317
			[Token(Token = "0x400207D")]
			MemberType_NONE,
			// Token: 0x0400207E RID: 8318
			[Token(Token = "0x400207E")]
			MemberType_NORMAL_MEMBER,
			// Token: 0x0400207F RID: 8319
			[Token(Token = "0x400207F")]
			MemberType_CAPTAIN
		}

		// Token: 0x02000673 RID: 1651
		[Token(Token = "0x2000673")]
		[ProtoContract]
		public enum TeamUserChangeType
		{
			// Token: 0x04002081 RID: 8321
			[Token(Token = "0x4002081")]
			TeamUserChangeType_NONE,
			// Token: 0x04002082 RID: 8322
			[Token(Token = "0x4002082")]
			TeamUserChangeType_REQUEST,
			// Token: 0x04002083 RID: 8323
			[Token(Token = "0x4002083")]
			TeamUserChangeType_APPROVE_APPLICATION,
			// Token: 0x04002084 RID: 8324
			[Token(Token = "0x4002084")]
			TeamUserChangeType_INVITE,
			// Token: 0x04002085 RID: 8325
			[Token(Token = "0x4002085")]
			TeamUserChangeType_APPROVE_INVITATION,
			// Token: 0x04002086 RID: 8326
			[Token(Token = "0x4002086")]
			TeamUserChangeType_REMOVE,
			// Token: 0x04002087 RID: 8327
			[Token(Token = "0x4002087")]
			TeamUserChangeType_QUIT,
			// Token: 0x04002088 RID: 8328
			[Token(Token = "0x4002088")]
			TeamUserChangeType_AUTO_QUIT
		}

		// Token: 0x02000674 RID: 1652
		[Token(Token = "0x2000674")]
		[ProtoContract]
		public enum ChampionshipPhase
		{
			// Token: 0x0400208A RID: 8330
			[Token(Token = "0x400208A")]
			ChampionshipPhase_NONE,
			// Token: 0x0400208B RID: 8331
			[Token(Token = "0x400208B")]
			ChampionshipPhase_TRIAL,
			// Token: 0x0400208C RID: 8332
			[Token(Token = "0x400208C")]
			ChampionshipPhase_FINAL
		}

		// Token: 0x02000675 RID: 1653
		[Token(Token = "0x2000675")]
		[ProtoContract]
		public enum TeamScaleType
		{
			// Token: 0x0400208E RID: 8334
			[Token(Token = "0x400208E")]
			TeamScaleType_NONE,
			// Token: 0x0400208F RID: 8335
			[Token(Token = "0x400208F")]
			TeamScaleType_SOLO,
			// Token: 0x04002090 RID: 8336
			[Token(Token = "0x4002090")]
			TeamScaleType_TRIO,
			// Token: 0x04002091 RID: 8337
			[Token(Token = "0x4002091")]
			TeamScaleType_QUINTET
		}
	}
}
