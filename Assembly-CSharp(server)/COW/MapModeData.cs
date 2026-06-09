using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001A07 RID: 6663
	[Token(Token = "0x2001A07")]
	public class MapModeData : IComparable<MapModeData>
	{
		// Token: 0x06008AA9 RID: 35497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008AA9")]
		[Address(RVA = "0x1A5770C", Offset = "0x1A5770C", VA = "0x7BBC25770C")]
		public MapModeData(uint matchMode, uint gameMode, uint mapMode, string spriteName, uint sortId)
		{
		}

		// Token: 0x06008AAA RID: 35498 RVA: 0x00025320 File Offset: 0x00023520
		[Token(Token = "0x6008AAA")]
		[Address(RVA = "0x1A577E0", Offset = "0x1A577E0", VA = "0x7BBC2577E0", Slot = "4")]
		public int CompareTo(MapModeData other)
		{
			return 0;
		}

		// Token: 0x06008AAB RID: 35499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008AAB")]
		[Address(RVA = "0x1A57874", Offset = "0x1A57874", VA = "0x7BBC257874")]
		public static implicit operator MapModeData(MapOpeningInfo openInfo)
		{
			return null;
		}

		// Token: 0x0400980B RID: 38923
		[Token(Token = "0x400980B")]
		[FieldOffset(Offset = "0x10")]
		public uint match_mode;

		// Token: 0x0400980C RID: 38924
		[Token(Token = "0x400980C")]
		[FieldOffset(Offset = "0x14")]
		public uint game_mode;

		// Token: 0x0400980D RID: 38925
		[Token(Token = "0x400980D")]
		[FieldOffset(Offset = "0x18")]
		public uint map_mode;

		// Token: 0x0400980E RID: 38926
		[Token(Token = "0x400980E")]
		[FieldOffset(Offset = "0x1C")]
		public uint info_id;

		// Token: 0x0400980F RID: 38927
		[Token(Token = "0x400980F")]
		[FieldOffset(Offset = "0x20")]
		public string bg_sprite;

		// Token: 0x04009810 RID: 38928
		[Token(Token = "0x4009810")]
		[FieldOffset(Offset = "0x28")]
		public bool is_new;

		// Token: 0x04009811 RID: 38929
		[Token(Token = "0x4009811")]
		[FieldOffset(Offset = "0x29")]
		public bool force_autoMatch;

		// Token: 0x04009812 RID: 38930
		[Token(Token = "0x4009812")]
		[FieldOffset(Offset = "0x2C")]
		public uint config_id;

		// Token: 0x04009813 RID: 38931
		[Token(Token = "0x4009813")]
		[FieldOffset(Offset = "0x30")]
		public uint level_visual_style;

		// Token: 0x04009814 RID: 38932
		[Token(Token = "0x4009814")]
		[FieldOffset(Offset = "0x38")]
		public List<int> difficulty;

		// Token: 0x04009815 RID: 38933
		[Token(Token = "0x4009815")]
		[FieldOffset(Offset = "0x40")]
		public uint sort_id;

		// Token: 0x04009816 RID: 38934
		[Token(Token = "0x4009816")]
		[FieldOffset(Offset = "0x44")]
		public uint tag;

		// Token: 0x04009817 RID: 38935
		[Token(Token = "0x4009817")]
		[FieldOffset(Offset = "0x48")]
		public string visualMapUrl;

		// Token: 0x04009818 RID: 38936
		[Token(Token = "0x4009818")]
		[FieldOffset(Offset = "0x50")]
		public string visualMapUrl02;

		// Token: 0x04009819 RID: 38937
		[Token(Token = "0x4009819")]
		[FieldOffset(Offset = "0x58")]
		public string tutorialUrl;

		// Token: 0x0400981A RID: 38938
		[Token(Token = "0x400981A")]
		[FieldOffset(Offset = "0x60")]
		public string awardUrl;

		// Token: 0x0400981B RID: 38939
		[Token(Token = "0x400981B")]
		[FieldOffset(Offset = "0x68")]
		public bool IsSpecialMode;

		// Token: 0x0400981C RID: 38940
		[Token(Token = "0x400981C")]
		[FieldOffset(Offset = "0x69")]
		public bool IsMapRandom;

		// Token: 0x0400981D RID: 38941
		[Token(Token = "0x400981D")]
		[FieldOffset(Offset = "0x70")]
		public string match_mode_image;

		// Token: 0x0400981E RID: 38942
		[Token(Token = "0x400981E")]
		[FieldOffset(Offset = "0x78")]
		public bool IsLiveOpen;

		// Token: 0x0400981F RID: 38943
		[Token(Token = "0x400981F")]
		[FieldOffset(Offset = "0x7C")]
		public uint LiveEffectsID;
	}
}
