using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020010D9 RID: 4313
	[Token(Token = "0x20010D9")]
	public class CSSharedAvatarData : CSVBaseData
	{
		// Token: 0x0600434C RID: 17228 RVA: 0x00014B08 File Offset: 0x00012D08
		[Token(Token = "0x600434C")]
		[Address(RVA = "0x14EE88C", Offset = "0x14EE88C", VA = "0x7BBBCEE88C")]
		public uint GetId()
		{
			return 0U;
		}

		// Token: 0x0600434D RID: 17229 RVA: 0x00014B20 File Offset: 0x00012D20
		[Token(Token = "0x600434D")]
		[Address(RVA = "0x14EE894", Offset = "0x14EE894", VA = "0x7BBBCEE894")]
		public bool IsFemale()
		{
			return default(bool);
		}

		// Token: 0x0600434E RID: 17230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600434E")]
		[Address(RVA = "0x14EE8A4", Offset = "0x14EE8A4", VA = "0x7BBBCEE8A4", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x0600434F RID: 17231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600434F")]
		[Address(RVA = "0x14EE8B0", Offset = "0x14EE8B0", VA = "0x7BBBCEE8B0", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x06004350 RID: 17232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004350")]
		[Address(RVA = "0x14EF2E4", Offset = "0x14EF2E4", VA = "0x7BBBCEF2E4")]
		public CSSharedAvatarData()
		{
		}

		// Token: 0x040052E0 RID: 21216
		[Token(Token = "0x40052E0")]
		[FieldOffset(Offset = "0x10")]
		public uint iID;

		// Token: 0x040052E1 RID: 21217
		[Token(Token = "0x40052E1")]
		[FieldOffset(Offset = "0x14")]
		public int sortID;

		// Token: 0x040052E2 RID: 21218
		[Token(Token = "0x40052E2")]
		[FieldOffset(Offset = "0x18")]
		public int gender;

		// Token: 0x040052E3 RID: 21219
		[Token(Token = "0x40052E3")]
		[FieldOffset(Offset = "0x1C")]
		public bool isDefault;

		// Token: 0x040052E4 RID: 21220
		[Token(Token = "0x40052E4")]
		[FieldOffset(Offset = "0x1D")]
		public bool isSelected;

		// Token: 0x040052E5 RID: 21221
		[Token(Token = "0x40052E5")]
		[FieldOffset(Offset = "0x20")]
		public ResourceID resIcon;

		// Token: 0x040052E6 RID: 21222
		[Token(Token = "0x40052E6")]
		[FieldOffset(Offset = "0x28")]
		public uint[] wardrobeType;

		// Token: 0x040052E7 RID: 21223
		[Token(Token = "0x40052E7")]
		[FieldOffset(Offset = "0x30")]
		public string[] recipeStrInGame;

		// Token: 0x040052E8 RID: 21224
		[Token(Token = "0x40052E8")]
		[FieldOffset(Offset = "0x38")]
		public string[] recipeStrInLobby;

		// Token: 0x040052E9 RID: 21225
		[Token(Token = "0x40052E9")]
		[FieldOffset(Offset = "0x40")]
		public string description;

		// Token: 0x040052EA RID: 21226
		[Token(Token = "0x40052EA")]
		[FieldOffset(Offset = "0x48")]
		public string name;

		// Token: 0x040052EB RID: 21227
		[Token(Token = "0x40052EB")]
		[FieldOffset(Offset = "0x50")]
		public string introduction;

		// Token: 0x040052EC RID: 21228
		[Token(Token = "0x40052EC")]
		[FieldOffset(Offset = "0x58")]
		public ResourceID resAnimation;

		// Token: 0x040052ED RID: 21229
		[Token(Token = "0x40052ED")]
		[FieldOffset(Offset = "0x5C")]
		public ResourceID resWalkAnimation;

		// Token: 0x040052EE RID: 21230
		[Token(Token = "0x40052EE")]
		[FieldOffset(Offset = "0x60")]
		public ResourceID resAvatar;

		// Token: 0x040052EF RID: 21231
		[Token(Token = "0x40052EF")]
		[FieldOffset(Offset = "0x64")]
		public ResourceID portrait;

		// Token: 0x040052F0 RID: 21232
		[Token(Token = "0x40052F0")]
		[FieldOffset(Offset = "0x68")]
		public ResourceID sharePortrait;

		// Token: 0x040052F1 RID: 21233
		[Token(Token = "0x40052F1")]
		[FieldOffset(Offset = "0x6C")]
		public ResourceID DecorPropIDRoot;

		// Token: 0x040052F2 RID: 21234
		[Token(Token = "0x40052F2")]
		[FieldOffset(Offset = "0x70")]
		public ResourceID DecorPropIDLeft;

		// Token: 0x040052F3 RID: 21235
		[Token(Token = "0x40052F3")]
		[FieldOffset(Offset = "0x74")]
		public ResourceID DecorPropIDRight;

		// Token: 0x040052F4 RID: 21236
		[Token(Token = "0x40052F4")]
		[FieldOffset(Offset = "0x78")]
		public ResourceID inGameSpecialAnim;

		// Token: 0x040052F5 RID: 21237
		[Token(Token = "0x40052F5")]
		[FieldOffset(Offset = "0x7C")]
		public Color defaultSkinColor;

		// Token: 0x040052F6 RID: 21238
		[Token(Token = "0x40052F6")]
		[FieldOffset(Offset = "0x8C")]
		public uint avatarSkillSlotID;

		// Token: 0x040052F7 RID: 21239
		[Token(Token = "0x40052F7")]
		[FieldOffset(Offset = "0x90")]
		public bool canChangeSkinColor;

		// Token: 0x040052F8 RID: 21240
		[Token(Token = "0x40052F8")]
		[FieldOffset(Offset = "0x91")]
		public bool isSpecialCharacter;

		// Token: 0x040052F9 RID: 21241
		[Token(Token = "0x40052F9")]
		[FieldOffset(Offset = "0x94")]
		public int animationInterval;

		// Token: 0x040052FA RID: 21242
		[Token(Token = "0x40052FA")]
		[FieldOffset(Offset = "0x98")]
		public int hairType;

		// Token: 0x040052FB RID: 21243
		[Token(Token = "0x40052FB")]
		[FieldOffset(Offset = "0x9C")]
		public uint bundleID;

		// Token: 0x040052FC RID: 21244
		[Token(Token = "0x40052FC")]
		[FieldOffset(Offset = "0xA0")]
		public uint luxuryBundleID;

		// Token: 0x040052FD RID: 21245
		[Token(Token = "0x40052FD")]
		[FieldOffset(Offset = "0xA4")]
		public ResourceID AlignmentIcon;

		// Token: 0x040052FE RID: 21246
		[Token(Token = "0x40052FE")]
		[FieldOffset(Offset = "0xA8")]
		public string AlignmentDesc;

		// Token: 0x040052FF RID: 21247
		[Token(Token = "0x40052FF")]
		[FieldOffset(Offset = "0xB0")]
		public string AlignmentName;

		// Token: 0x04005300 RID: 21248
		[Token(Token = "0x4005300")]
		[FieldOffset(Offset = "0xB8")]
		public uint pvePrimaryWeapon;

		// Token: 0x04005301 RID: 21249
		[Token(Token = "0x4005301")]
		[FieldOffset(Offset = "0xBC")]
		public bool HeadAdditiveSwitch;

		// Token: 0x04005302 RID: 21250
		[Token(Token = "0x4005302")]
		[FieldOffset(Offset = "0xBD")]
		public bool IsActiveSkill;
	}
}
