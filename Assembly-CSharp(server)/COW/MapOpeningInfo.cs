using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001F5C RID: 8028
	[Token(Token = "0x2001F5C")]
	public class MapOpeningInfo
	{
		// Token: 0x0600B0A2 RID: 45218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B0A2")]
		[Address(RVA = "0x1A57A20", Offset = "0x1A57A20", VA = "0x7BBC257A20")]
		public static implicit operator MapOpeningInfo(GameOpeningInfoDesc desc)
		{
			return null;
		}

		// Token: 0x0600B0A3 RID: 45219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B0A3")]
		[Address(RVA = "0x1A58940", Offset = "0x1A58940", VA = "0x7BBC258940")]
		public MapOpeningInfo()
		{
		}

		// Token: 0x0400B415 RID: 46101
		[Token(Token = "0x400B415")]
		[FieldOffset(Offset = "0x10")]
		public MapConfigData MapConfigData;

		// Token: 0x0400B416 RID: 46102
		[Token(Token = "0x400B416")]
		[FieldOffset(Offset = "0x18")]
		public DateTime StartTimeInDay;

		// Token: 0x0400B417 RID: 46103
		[Token(Token = "0x400B417")]
		[FieldOffset(Offset = "0x20")]
		public uint[] Weekdays;

		// Token: 0x0400B418 RID: 46104
		[Token(Token = "0x400B418")]
		[FieldOffset(Offset = "0x28")]
		public DateTime EndTimeInDay;

		// Token: 0x0400B419 RID: 46105
		[Token(Token = "0x400B419")]
		[FieldOffset(Offset = "0x30")]
		public string Tips;

		// Token: 0x0400B41A RID: 46106
		[Token(Token = "0x400B41A")]
		[FieldOffset(Offset = "0x38")]
		public uint MatchMode;

		// Token: 0x0400B41B RID: 46107
		[Token(Token = "0x400B41B")]
		[FieldOffset(Offset = "0x3C")]
		public uint InfoUniqueID;

		// Token: 0x0400B41C RID: 46108
		[Token(Token = "0x400B41C")]
		[FieldOffset(Offset = "0x40")]
		public bool IsNew;

		// Token: 0x0400B41D RID: 46109
		[Token(Token = "0x400B41D")]
		[FieldOffset(Offset = "0x41")]
		public bool IsPermanent;

		// Token: 0x0400B41E RID: 46110
		[Token(Token = "0x400B41E")]
		[FieldOffset(Offset = "0x42")]
		public bool ForceAutoMatch;

		// Token: 0x0400B41F RID: 46111
		[Token(Token = "0x400B41F")]
		[FieldOffset(Offset = "0x44")]
		public uint LevelVisualStyle;

		// Token: 0x0400B420 RID: 46112
		[Token(Token = "0x400B420")]
		[FieldOffset(Offset = "0x48")]
		public uint[] playerCounts;

		// Token: 0x0400B421 RID: 46113
		[Token(Token = "0x400B421")]
		[FieldOffset(Offset = "0x50")]
		public DateTime ConfigStartTime;

		// Token: 0x0400B422 RID: 46114
		[Token(Token = "0x400B422")]
		[FieldOffset(Offset = "0x58")]
		public DateTime ConfigEndTime;

		// Token: 0x0400B423 RID: 46115
		[Token(Token = "0x400B423")]
		[FieldOffset(Offset = "0x60")]
		public uint SortId;

		// Token: 0x0400B424 RID: 46116
		[Token(Token = "0x400B424")]
		[FieldOffset(Offset = "0x68")]
		public List<int> difficulty;

		// Token: 0x0400B425 RID: 46117
		[Token(Token = "0x400B425")]
		[FieldOffset(Offset = "0x70")]
		public uint tag;

		// Token: 0x0400B426 RID: 46118
		[Token(Token = "0x400B426")]
		[FieldOffset(Offset = "0x78")]
		public string visualMapUrl;

		// Token: 0x0400B427 RID: 46119
		[Token(Token = "0x400B427")]
		[FieldOffset(Offset = "0x80")]
		public string visualMapUrl02;

		// Token: 0x0400B428 RID: 46120
		[Token(Token = "0x400B428")]
		[FieldOffset(Offset = "0x88")]
		public string tutorialUrl;

		// Token: 0x0400B429 RID: 46121
		[Token(Token = "0x400B429")]
		[FieldOffset(Offset = "0x90")]
		public string awardUrl;

		// Token: 0x0400B42A RID: 46122
		[Token(Token = "0x400B42A")]
		[FieldOffset(Offset = "0x98")]
		public string[] version;

		// Token: 0x0400B42B RID: 46123
		[Token(Token = "0x400B42B")]
		[FieldOffset(Offset = "0xA0")]
		public bool is_random;

		// Token: 0x0400B42C RID: 46124
		[Token(Token = "0x400B42C")]
		[FieldOffset(Offset = "0xA8")]
		public string match_mode_image;

		// Token: 0x0400B42D RID: 46125
		[Token(Token = "0x400B42D")]
		[FieldOffset(Offset = "0xB0")]
		public bool is_force_random;

		// Token: 0x0400B42E RID: 46126
		[Token(Token = "0x400B42E")]
		[FieldOffset(Offset = "0xB1")]
		public bool is_live_open;

		// Token: 0x0400B42F RID: 46127
		[Token(Token = "0x400B42F")]
		[FieldOffset(Offset = "0xB4")]
		public uint live_effects_id;

		// Token: 0x0400B430 RID: 46128
		[Token(Token = "0x400B430")]
		[FieldOffset(Offset = "0xB8")]
		private DateTime m_Date;
	}
}
