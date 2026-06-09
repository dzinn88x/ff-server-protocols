using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020010CB RID: 4299
	[Token(Token = "0x20010CB")]
	public class WeaponSkinData : CsvDataIndexedReading
	{
		// Token: 0x06004305 RID: 17157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004305")]
		[Address(RVA = "0x179D7C8", Offset = "0x179D7C8", VA = "0x7BBBF9D7C8", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x06004306 RID: 17158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004306")]
		[Address(RVA = "0x179D7D4", Offset = "0x179D7D4", VA = "0x7BBBF9D7D4", Slot = "7")]
		public override string[] GetHeadColNames()
		{
			return null;
		}

		// Token: 0x06004307 RID: 17159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004307")]
		[Address(RVA = "0x179E454", Offset = "0x179E454", VA = "0x7BBBF9E454", Slot = "8")]
		public override void ParseData(IIndexString ss, int[] index)
		{
		}

		// Token: 0x06004308 RID: 17160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004308")]
		[Address(RVA = "0x179FA40", Offset = "0x179FA40", VA = "0x7BBBF9FA40")]
		public WeaponSkinData()
		{
		}

		// Token: 0x0400525F RID: 21087
		[Token(Token = "0x400525F")]
		[FieldOffset(Offset = "0x10")]
		public uint iID;

		// Token: 0x04005260 RID: 21088
		[Token(Token = "0x4005260")]
		[FieldOffset(Offset = "0x14")]
		public uint WeaponID;

		// Token: 0x04005261 RID: 21089
		[Token(Token = "0x4005261")]
		[FieldOffset(Offset = "0x18")]
		public uint LabelID;

		// Token: 0x04005262 RID: 21090
		[Token(Token = "0x4005262")]
		[FieldOffset(Offset = "0x1C")]
		public uint AnimationID;

		// Token: 0x04005263 RID: 21091
		[Token(Token = "0x4005263")]
		[FieldOffset(Offset = "0x20")]
		public uint sortId;

		// Token: 0x04005264 RID: 21092
		[Token(Token = "0x4005264")]
		[FieldOffset(Offset = "0x24")]
		public uint Announcement;

		// Token: 0x04005265 RID: 21093
		[Token(Token = "0x4005265")]
		[FieldOffset(Offset = "0x28")]
		public uint WeaponSet;

		// Token: 0x04005266 RID: 21094
		[Token(Token = "0x4005266")]
		[FieldOffset(Offset = "0x2C")]
		public uint SkinLevel;

		// Token: 0x04005267 RID: 21095
		[Token(Token = "0x4005267")]
		[FieldOffset(Offset = "0x30")]
		public ResourceID previewRes;

		// Token: 0x04005268 RID: 21096
		[Token(Token = "0x4005268")]
		[FieldOffset(Offset = "0x34")]
		public ResourceID inGameRes3P;

		// Token: 0x04005269 RID: 21097
		[Token(Token = "0x4005269")]
		[FieldOffset(Offset = "0x38")]
		public ResourceID inGameRes1P;

		// Token: 0x0400526A RID: 21098
		[Token(Token = "0x400526A")]
		[FieldOffset(Offset = "0x3C")]
		public ResourceID BackRes;

		// Token: 0x0400526B RID: 21099
		[Token(Token = "0x400526B")]
		[FieldOffset(Offset = "0x40")]
		public ResourceID previewEffectRes;

		// Token: 0x0400526C RID: 21100
		[Token(Token = "0x400526C")]
		[FieldOffset(Offset = "0x44")]
		public ResourceID ParticleRes;

		// Token: 0x0400526D RID: 21101
		[Token(Token = "0x400526D")]
		[FieldOffset(Offset = "0x48")]
		public ResourceID FireEffect;

		// Token: 0x0400526E RID: 21102
		[Token(Token = "0x400526E")]
		[FieldOffset(Offset = "0x4C")]
		public ResourceID FireSound;

		// Token: 0x0400526F RID: 21103
		[Token(Token = "0x400526F")]
		[FieldOffset(Offset = "0x50")]
		public ResourceID PVEIconResID;

		// Token: 0x04005270 RID: 21104
		[Token(Token = "0x4005270")]
		[FieldOffset(Offset = "0x54")]
		public ResourceID AnnouncementType;

		// Token: 0x04005271 RID: 21105
		[Token(Token = "0x4005271")]
		[FieldOffset(Offset = "0x58")]
		public ResourceID CampIcon;

		// Token: 0x04005272 RID: 21106
		[Token(Token = "0x4005272")]
		[FieldOffset(Offset = "0x5C")]
		public ResourceID PreviewShootEffect;

		// Token: 0x04005273 RID: 21107
		[Token(Token = "0x4005273")]
		[FieldOffset(Offset = "0x60")]
		public ResourceID PreviewHitEffect;

		// Token: 0x04005274 RID: 21108
		[Token(Token = "0x4005274")]
		[FieldOffset(Offset = "0x64")]
		public ResourceID IngameHitEffect;

		// Token: 0x04005275 RID: 21109
		[Token(Token = "0x4005275")]
		[FieldOffset(Offset = "0x68")]
		public ResourceID PreviewKillEffect;

		// Token: 0x04005276 RID: 21110
		[Token(Token = "0x4005276")]
		[FieldOffset(Offset = "0x6C")]
		public ResourceID IngameKillEffect;

		// Token: 0x04005277 RID: 21111
		[Token(Token = "0x4005277")]
		[FieldOffset(Offset = "0x70")]
		public ResourceID FullScreenEffect;

		// Token: 0x04005278 RID: 21112
		[Token(Token = "0x4005278")]
		[FieldOffset(Offset = "0x74")]
		public ResourceID PreviewGunTraceEffect;

		// Token: 0x04005279 RID: 21113
		[Token(Token = "0x4005279")]
		[FieldOffset(Offset = "0x78")]
		public ResourceID IngameGunTraceEffect;

		// Token: 0x0400527A RID: 21114
		[Token(Token = "0x400527A")]
		[FieldOffset(Offset = "0x7C")]
		public bool IsWithEffect;

		// Token: 0x0400527B RID: 21115
		[Token(Token = "0x400527B")]
		[FieldOffset(Offset = "0x7D")]
		public bool IsShow;

		// Token: 0x0400527C RID: 21116
		[Token(Token = "0x400527C")]
		[FieldOffset(Offset = "0x7E")]
		public bool IsPVE_WeaponSkin;
	}
}
