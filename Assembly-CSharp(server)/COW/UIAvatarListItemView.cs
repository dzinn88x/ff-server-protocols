using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002100 RID: 8448
	[Token(Token = "0x2002100")]
	public class UIAvatarListItemView : UIBaseView
	{
		// Token: 0x0600BD11 RID: 48401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD11")]
		[Address(RVA = "0x2074EB0", Offset = "0x2074EB0", VA = "0x7BBC874EB0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BD12 RID: 48402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD12")]
		[Address(RVA = "0x2075540", Offset = "0x2075540", VA = "0x7BBC875540")]
		public UIAvatarListItemView()
		{
		}

		// Token: 0x0400C036 RID: 49206
		[Token(Token = "0x400C036")]
		[FieldOffset(Offset = "0x20")]
		public UIButton AvatarBtn;

		// Token: 0x0400C037 RID: 49207
		[Token(Token = "0x400C037")]
		[FieldOffset(Offset = "0x28")]
		public GameObject Tips;

		// Token: 0x0400C038 RID: 49208
		[Token(Token = "0x400C038")]
		[FieldOffset(Offset = "0x30")]
		public GameObject SelectedBorder;

		// Token: 0x0400C039 RID: 49209
		[Token(Token = "0x400C039")]
		[FieldOffset(Offset = "0x38")]
		public GameObject SelectedObject;

		// Token: 0x0400C03A RID: 49210
		[Token(Token = "0x400C03A")]
		[FieldOffset(Offset = "0x40")]
		public UILabel SelectedNameLabel;

		// Token: 0x0400C03B RID: 49211
		[Token(Token = "0x400C03B")]
		[FieldOffset(Offset = "0x48")]
		public GameObject UnSelectedObject;

		// Token: 0x0400C03C RID: 49212
		[Token(Token = "0x400C03C")]
		[FieldOffset(Offset = "0x50")]
		public UILabel UnSelectedNameLabel;

		// Token: 0x0400C03D RID: 49213
		[Token(Token = "0x400C03D")]
		[FieldOffset(Offset = "0x58")]
		public GameObject LockedObject;

		// Token: 0x0400C03E RID: 49214
		[Token(Token = "0x400C03E")]
		[FieldOffset(Offset = "0x60")]
		public GameObject UnLockedObject;

		// Token: 0x0400C03F RID: 49215
		[Token(Token = "0x400C03F")]
		[FieldOffset(Offset = "0x68")]
		public AvatarSelectionSkillSlot SkillSlotContainer;

		// Token: 0x0400C040 RID: 49216
		[Token(Token = "0x400C040")]
		[FieldOffset(Offset = "0x70")]
		public UIGrid SkillGrid;

		// Token: 0x0400C041 RID: 49217
		[Token(Token = "0x400C041")]
		[FieldOffset(Offset = "0x78")]
		public Transform SlotPos_1;

		// Token: 0x0400C042 RID: 49218
		[Token(Token = "0x400C042")]
		[FieldOffset(Offset = "0x80")]
		public UIAvatarSkillSlotMono AvatarSkillSlotMono1;

		// Token: 0x0400C043 RID: 49219
		[Token(Token = "0x400C043")]
		[FieldOffset(Offset = "0x88")]
		public Transform SlotPos_2;

		// Token: 0x0400C044 RID: 49220
		[Token(Token = "0x400C044")]
		[FieldOffset(Offset = "0x90")]
		public UIAvatarSkillSlotMono AvatarSkillSlotMono2;

		// Token: 0x0400C045 RID: 49221
		[Token(Token = "0x400C045")]
		[FieldOffset(Offset = "0x98")]
		public Transform SlotPos_3;

		// Token: 0x0400C046 RID: 49222
		[Token(Token = "0x400C046")]
		[FieldOffset(Offset = "0xA0")]
		public UIAvatarSkillSlotMono AvatarSkillSlotMono3;

		// Token: 0x0400C047 RID: 49223
		[Token(Token = "0x400C047")]
		[FieldOffset(Offset = "0xA8")]
		public Transform SlotPos_4;

		// Token: 0x0400C048 RID: 49224
		[Token(Token = "0x400C048")]
		[FieldOffset(Offset = "0xB0")]
		public UIAvatarSkillSlotMono AvatarSkillSlotMono4;

		// Token: 0x0400C049 RID: 49225
		[Token(Token = "0x400C049")]
		[FieldOffset(Offset = "0xB8")]
		public UISprite AvatarImage;

		// Token: 0x0400C04A RID: 49226
		[Token(Token = "0x400C04A")]
		[FieldOffset(Offset = "0xC0")]
		public UISprite IPTag;

		// Token: 0x0400C04B RID: 49227
		[Token(Token = "0x400C04B")]
		[FieldOffset(Offset = "0xC8")]
		public UISprite AwakenIconGray;

		// Token: 0x0400C04C RID: 49228
		[Token(Token = "0x400C04C")]
		[FieldOffset(Offset = "0xD0")]
		public UISprite AwakenIconNormal;

		// Token: 0x0400C04D RID: 49229
		[Token(Token = "0x400C04D")]
		[FieldOffset(Offset = "0xD8")]
		public UILabel AvatarLevel;

		// Token: 0x0400C04E RID: 49230
		[Token(Token = "0x400C04E")]
		[FieldOffset(Offset = "0xE0")]
		public GameObject ExpireIcon;

		// Token: 0x0400C04F RID: 49231
		[Token(Token = "0x400C04F")]
		[FieldOffset(Offset = "0xE8")]
		public GameObject VFX_awaken;
	}
}
