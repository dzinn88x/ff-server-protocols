using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001147 RID: 4423
	[Token(Token = "0x2001147")]
	public class MapConfigData : CSVBaseData
	{
		// Token: 0x06004506 RID: 17670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004506")]
		[Address(RVA = "0x1A56E80", Offset = "0x1A56E80", VA = "0x7BBC256E80", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x06004507 RID: 17671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004507")]
		[Address(RVA = "0x1A56E8C", Offset = "0x1A56E8C", VA = "0x7BBC256E8C", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x06004508 RID: 17672 RVA: 0x00015168 File Offset: 0x00013368
		[Token(Token = "0x6004508")]
		[Address(RVA = "0x1A575EC", Offset = "0x1A575EC", VA = "0x7BBC2575EC")]
		public static uint MakeConfigID(uint map_id, uint mode_id)
		{
			return 0U;
		}

		// Token: 0x06004509 RID: 17673 RVA: 0x00015180 File Offset: 0x00013380
		[Token(Token = "0x6004509")]
		[Address(RVA = "0x1A575F8", Offset = "0x1A575F8", VA = "0x7BBC2575F8")]
		public static uint GetMapIDFromConfigID(uint configID)
		{
			return 0U;
		}

		// Token: 0x0600450A RID: 17674 RVA: 0x00015198 File Offset: 0x00013398
		[Token(Token = "0x600450A")]
		[Address(RVA = "0x1A5760C", Offset = "0x1A5760C", VA = "0x7BBC25760C")]
		public static uint GetModeIDFromConfigID(uint configID)
		{
			return 0U;
		}

		// Token: 0x0600450B RID: 17675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600450B")]
		[Address(RVA = "0x1A57628", Offset = "0x1A57628", VA = "0x7BBC257628")]
		public MapConfigData()
		{
		}

		// Token: 0x0400555E RID: 21854
		[Token(Token = "0x400555E")]
		public const uint DEFAULT_MAP_ID = 1U;

		// Token: 0x0400555F RID: 21855
		[Token(Token = "0x400555F")]
		[FieldOffset(Offset = "0x10")]
		public string MapName;

		// Token: 0x04005560 RID: 21856
		[Token(Token = "0x4005560")]
		[FieldOffset(Offset = "0x18")]
		public string WaitingMapName;

		// Token: 0x04005561 RID: 21857
		[Token(Token = "0x4005561")]
		[FieldOffset(Offset = "0x20")]
		public string MiniMapLocKey;

		// Token: 0x04005562 RID: 21858
		[Token(Token = "0x4005562")]
		[FieldOffset(Offset = "0x28")]
		public string MapBgSpriteName;

		// Token: 0x04005563 RID: 21859
		[Token(Token = "0x4005563")]
		[FieldOffset(Offset = "0x30")]
		public string OpeningSoundID;

		// Token: 0x04005564 RID: 21860
		[Token(Token = "0x4005564")]
		[FieldOffset(Offset = "0x38")]
		public uint ConfigID;

		// Token: 0x04005565 RID: 21861
		[Token(Token = "0x4005565")]
		[FieldOffset(Offset = "0x3C")]
		public uint MapID;

		// Token: 0x04005566 RID: 21862
		[Token(Token = "0x4005566")]
		[FieldOffset(Offset = "0x40")]
		public uint ModeID;

		// Token: 0x04005567 RID: 21863
		[Token(Token = "0x4005567")]
		[FieldOffset(Offset = "0x44")]
		public ResourceID MapResourceID;

		// Token: 0x04005568 RID: 21864
		[Token(Token = "0x4005568")]
		[FieldOffset(Offset = "0x48")]
		public ResourceID MapABTexRefInfoID;

		// Token: 0x04005569 RID: 21865
		[Token(Token = "0x4005569")]
		[FieldOffset(Offset = "0x4C")]
		public ResourceID WaitingMapResourceID;

		// Token: 0x0400556A RID: 21866
		[Token(Token = "0x400556A")]
		[FieldOffset(Offset = "0x50")]
		public ResourceID ModeMapResourceID;

		// Token: 0x0400556B RID: 21867
		[Token(Token = "0x400556B")]
		[FieldOffset(Offset = "0x54")]
		public ResourceID ModeDepAbFakeResID;

		// Token: 0x0400556C RID: 21868
		[Token(Token = "0x400556C")]
		[FieldOffset(Offset = "0x58")]
		public ResourceID BigMapBgResourceID;

		// Token: 0x0400556D RID: 21869
		[Token(Token = "0x400556D")]
		[FieldOffset(Offset = "0x5C")]
		public ResourceID ShowPositionResourceID;

		// Token: 0x0400556E RID: 21870
		[Token(Token = "0x400556E")]
		[FieldOffset(Offset = "0x60")]
		public bool IsNoWaitingMap;

		// Token: 0x0400556F RID: 21871
		[Token(Token = "0x400556F")]
		[FieldOffset(Offset = "0x61")]
		public bool IsNoSafeZone;

		// Token: 0x04005570 RID: 21872
		[Token(Token = "0x4005570")]
		[FieldOffset(Offset = "0x62")]
		public bool IsNoJumping;
	}
}
