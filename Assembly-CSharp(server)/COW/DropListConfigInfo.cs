using System;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001D05 RID: 7429
	[Token(Token = "0x2001D05")]
	public struct DropListConfigInfo
	{
		// Token: 0x0400A83A RID: 43066
		[Token(Token = "0x400A83A")]
		[FieldOffset(Offset = "0x0")]
		public uint ID;

		// Token: 0x0400A83B RID: 43067
		[Token(Token = "0x400A83B")]
		[FieldOffset(Offset = "0x8")]
		public string LocKey;

		// Token: 0x0400A83C RID: 43068
		[Token(Token = "0x400A83C")]
		[FieldOffset(Offset = "0x10")]
		public ERoom.WeatherType WeatherType;

		// Token: 0x0400A83D RID: 43069
		[Token(Token = "0x400A83D")]
		[FieldOffset(Offset = "0x14")]
		public ERoom.DropPresetState UnlimitedAmmo;

		// Token: 0x0400A83E RID: 43070
		[Token(Token = "0x400A83E")]
		[FieldOffset(Offset = "0x18")]
		public ERoom.DropPresetState Skill;

		// Token: 0x0400A83F RID: 43071
		[Token(Token = "0x400A83F")]
		[FieldOffset(Offset = "0x1C")]
		public ERoom.DropPresetState AirDrop;

		// Token: 0x0400A840 RID: 43072
		[Token(Token = "0x400A840")]
		[FieldOffset(Offset = "0x20")]
		public ERoom.DropPresetState FallDown;

		// Token: 0x0400A841 RID: 43073
		[Token(Token = "0x400A841")]
		[FieldOffset(Offset = "0x24")]
		public ERoom.DropPresetState Loadout;

		// Token: 0x0400A842 RID: 43074
		[Token(Token = "0x400A842")]
		[FieldOffset(Offset = "0x28")]
		public ERoom.DropPresetState Vehicle;

		// Token: 0x0400A843 RID: 43075
		[Token(Token = "0x400A843")]
		[FieldOffset(Offset = "0x2C")]
		public ERoom.DropPresetState Zeppelin;
	}
}
