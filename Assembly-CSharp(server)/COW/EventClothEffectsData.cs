using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020010F8 RID: 4344
	[Token(Token = "0x20010F8")]
	public class EventClothEffectsData : CSVBaseData
	{
		// Token: 0x060043D1 RID: 17361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043D1")]
		[Address(RVA = "0x1B887D8", Offset = "0x1B887D8", VA = "0x7BBC3887D8", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x060043D2 RID: 17362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043D2")]
		[Address(RVA = "0x1B887E4", Offset = "0x1B887E4", VA = "0x7BBC3887E4", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x060043D3 RID: 17363 RVA: 0x00014CA0 File Offset: 0x00012EA0
		[Token(Token = "0x60043D3")]
		[Address(RVA = "0x1B88CB4", Offset = "0x1B88CB4", VA = "0x7BBC388CB4")]
		public bool HasLobbySpecializedEffect(bool isFemale)
		{
			return default(bool);
		}

		// Token: 0x060043D4 RID: 17364 RVA: 0x00014CB8 File Offset: 0x00012EB8
		[Token(Token = "0x60043D4")]
		[Address(RVA = "0x1B88D54", Offset = "0x1B88D54", VA = "0x7BBC388D54")]
		public ResourceID GetLobbyEffect(bool isFemale)
		{
			return default(ResourceID);
		}

		// Token: 0x060043D5 RID: 17365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043D5")]
		[Address(RVA = "0x1B88628", Offset = "0x1B88628", VA = "0x7BBC388628")]
		public static EventClothEffectsData PartialClone(EventClothEffectsData d)
		{
			return null;
		}

		// Token: 0x060043D6 RID: 17366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043D6")]
		[Address(RVA = "0x1B88E3C", Offset = "0x1B88E3C", VA = "0x7BBC388E3C")]
		public EventClothEffectsData()
		{
		}

		// Token: 0x040053D7 RID: 21463
		[Token(Token = "0x40053D7")]
		[FieldOffset(Offset = "0x10")]
		public uint StateID;

		// Token: 0x040053D8 RID: 21464
		[Token(Token = "0x40053D8")]
		[FieldOffset(Offset = "0x14")]
		public uint ClothID;

		// Token: 0x040053D9 RID: 21465
		[Token(Token = "0x40053D9")]
		[FieldOffset(Offset = "0x18")]
		public uint EffectsTriggerID;

		// Token: 0x040053DA RID: 21466
		[Token(Token = "0x40053DA")]
		[FieldOffset(Offset = "0x1C")]
		public uint StackType;

		// Token: 0x040053DB RID: 21467
		[Token(Token = "0x40053DB")]
		[FieldOffset(Offset = "0x20")]
		public uint EffectPlayDuration;

		// Token: 0x040053DC RID: 21468
		[Token(Token = "0x40053DC")]
		[FieldOffset(Offset = "0x24")]
		public uint PlayTime;

		// Token: 0x040053DD RID: 21469
		[Token(Token = "0x40053DD")]
		[FieldOffset(Offset = "0x28")]
		public ResourceID EffectIDM;

		// Token: 0x040053DE RID: 21470
		[Token(Token = "0x40053DE")]
		[FieldOffset(Offset = "0x2C")]
		public ResourceID EffectIDF;

		// Token: 0x040053DF RID: 21471
		[Token(Token = "0x40053DF")]
		[FieldOffset(Offset = "0x30")]
		public ResourceID LobbyEffectIDM;

		// Token: 0x040053E0 RID: 21472
		[Token(Token = "0x40053E0")]
		[FieldOffset(Offset = "0x34")]
		public ResourceID LobbyEffectIDF;
	}
}
