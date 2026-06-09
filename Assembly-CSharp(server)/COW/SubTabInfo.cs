using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200158D RID: 5517
	[Token(Token = "0x200158D")]
	public class SubTabInfo
	{
		// Token: 0x06006068 RID: 24680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006068")]
		[Address(RVA = "0x1B40BA8", Offset = "0x1B40BA8", VA = "0x7BBC340BA8")]
		public SubTabInfo(UIModelAvatarBase.EWardrobeType wardrobetype, string sprite_name)
		{
		}

		// Token: 0x06006069 RID: 24681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006069")]
		[Address(RVA = "0x1B40BE4", Offset = "0x1B40BE4", VA = "0x7BBC340BE4")]
		public SubTabInfo(CSSharedItemDataManager.CollectionSubType collectionType, string sprite_name)
		{
		}

		// Token: 0x0600606A RID: 24682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600606A")]
		[Address(RVA = "0x1B40C20", Offset = "0x1B40C20", VA = "0x7BBC340C20")]
		public SubTabInfo(CSSharedItemDataManager.CharacterSubType characterType, string sprite_name)
		{
		}

		// Token: 0x0600606B RID: 24683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600606B")]
		[Address(RVA = "0x1B40C5C", Offset = "0x1B40C5C", VA = "0x7BBC340C5C")]
		public SubTabInfo(CSSharedItemDataManager.PetSubType itemType, string sprite_name)
		{
		}

		// Token: 0x04008093 RID: 32915
		[Token(Token = "0x4008093")]
		[FieldOffset(Offset = "0x10")]
		public uint TabType;

		// Token: 0x04008094 RID: 32916
		[Token(Token = "0x4008094")]
		[FieldOffset(Offset = "0x18")]
		public string SpriteName;

		// Token: 0x04008095 RID: 32917
		[Token(Token = "0x4008095")]
		[FieldOffset(Offset = "0x20")]
		public UIToggleButton ToggleButton;
	}
}
