using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020010AA RID: 4266
	[Token(Token = "0x20010AA")]
	public class EpicClothesTextData : CSVBaseData, IGetId
	{
		// Token: 0x0600428D RID: 17037 RVA: 0x00014820 File Offset: 0x00012A20
		[Token(Token = "0x600428D")]
		[Address(RVA = "0x1B87014", Offset = "0x1B87014", VA = "0x7BBC387014", Slot = "9")]
		public uint GetId()
		{
			return 0U;
		}

		// Token: 0x0600428E RID: 17038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600428E")]
		[Address(RVA = "0x1B8701C", Offset = "0x1B8701C", VA = "0x7BBC38701C", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x0600428F RID: 17039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600428F")]
		[Address(RVA = "0x1B87028", Offset = "0x1B87028", VA = "0x7BBC387028", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x06004290 RID: 17040 RVA: 0x00014838 File Offset: 0x00012A38
		[Token(Token = "0x6004290")]
		[Address(RVA = "0x1B872A0", Offset = "0x1B872A0", VA = "0x7BBC3872A0")]
		public ResourceID GetKillEffect(int level)
		{
			return default(ResourceID);
		}

		// Token: 0x06004291 RID: 17041 RVA: 0x00014850 File Offset: 0x00012A50
		[Token(Token = "0x6004291")]
		[Address(RVA = "0x1B87378", Offset = "0x1B87378", VA = "0x7BBC387378")]
		public ResourceID GetActionEffect(int level)
		{
			return default(ResourceID);
		}

		// Token: 0x06004292 RID: 17042 RVA: 0x00014868 File Offset: 0x00012A68
		[Token(Token = "0x6004292")]
		[Address(RVA = "0x1B873A0", Offset = "0x1B873A0", VA = "0x7BBC3873A0")]
		public ResourceID GetInGameActionEffect(int level)
		{
			return default(ResourceID);
		}

		// Token: 0x06004293 RID: 17043 RVA: 0x00014880 File Offset: 0x00012A80
		[Token(Token = "0x6004293")]
		[Address(RVA = "0x1B872C8", Offset = "0x1B872C8", VA = "0x7BBC3872C8")]
		public ResourceID GetEffect(ResourceID[] reses, int level)
		{
			return default(ResourceID);
		}

		// Token: 0x06004294 RID: 17044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004294")]
		[Address(RVA = "0x1B873C8", Offset = "0x1B873C8", VA = "0x7BBC3873C8")]
		public EpicClothesTextData()
		{
		}

		// Token: 0x04005194 RID: 20884
		[Token(Token = "0x4005194")]
		[FieldOffset(Offset = "0x10")]
		public uint ClothesID;

		// Token: 0x04005195 RID: 20885
		[Token(Token = "0x4005195")]
		[FieldOffset(Offset = "0x18")]
		public string[] Conditions;

		// Token: 0x04005196 RID: 20886
		[Token(Token = "0x4005196")]
		[FieldOffset(Offset = "0x20")]
		public ResourceID WaitingRoomEffect;

		// Token: 0x04005197 RID: 20887
		[Token(Token = "0x4005197")]
		[FieldOffset(Offset = "0x28")]
		public ResourceID[] KillEffects;

		// Token: 0x04005198 RID: 20888
		[Token(Token = "0x4005198")]
		[FieldOffset(Offset = "0x30")]
		public ResourceID[] ActionEffects;

		// Token: 0x04005199 RID: 20889
		[Token(Token = "0x4005199")]
		[FieldOffset(Offset = "0x38")]
		public ResourceID[] InGameActionEffects;

		// Token: 0x0400519A RID: 20890
		[Token(Token = "0x400519A")]
		[FieldOffset(Offset = "0x40")]
		public ResourceID Flag;

		// Token: 0x0400519B RID: 20891
		[Token(Token = "0x400519B")]
		[FieldOffset(Offset = "0x44")]
		public uint ChickenSprite;

		// Token: 0x0400519C RID: 20892
		[Token(Token = "0x400519C")]
		[FieldOffset(Offset = "0x48")]
		public uint LootBox;
	}
}
