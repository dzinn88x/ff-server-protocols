using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001C46 RID: 7238
	[Token(Token = "0x2001C46")]
	public class BaseItemView : MonoBehaviour
	{
		// Token: 0x06009D56 RID: 40278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009D56")]
		[Address(RVA = "0x21C9B0C", Offset = "0x21C9B0C", VA = "0x7BBC9C9B0C", Slot = "4")]
		public virtual void SetViewData(BaseItemInfo m_Data)
		{
		}

		// Token: 0x06009D57 RID: 40279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009D57")]
		[Address(RVA = "0x21D3C38", Offset = "0x21D3C38", VA = "0x7BBC9D3C38")]
		public UISprite GetItemSprite()
		{
			return null;
		}

		// Token: 0x06009D58 RID: 40280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009D58")]
		[Address(RVA = "0x21D3C40", Offset = "0x21D3C40", VA = "0x7BBC9D3C40")]
		public void SetSpriteSize(int width, int height)
		{
		}

		// Token: 0x06009D59 RID: 40281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009D59")]
		[Address(RVA = "0x21D3D14", Offset = "0x21D3D14", VA = "0x7BBC9D3D14")]
		public void SetFlowLightEnable(bool b)
		{
		}

		// Token: 0x06009D5A RID: 40282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009D5A")]
		[Address(RVA = "0x21D3A14", Offset = "0x21D3A14", VA = "0x7BBC9D3A14")]
		public void AdjustShadowPic(UISprite spr)
		{
		}

		// Token: 0x06009D5B RID: 40283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009D5B")]
		[Address(RVA = "0x21CB2EC", Offset = "0x21CB2EC", VA = "0x7BBC9CB2EC")]
		public BaseItemView()
		{
		}

		// Token: 0x0400A348 RID: 41800
		[Token(Token = "0x400A348")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIUtils.SpriteScaleType m_SpriteFixedType;

		// Token: 0x0400A349 RID: 41801
		[Token(Token = "0x400A349")]
		[FieldOffset(Offset = "0x1C")]
		public bool m_ItemUsePerfect;

		// Token: 0x0400A34A RID: 41802
		[Token(Token = "0x400A34A")]
		[FieldOffset(Offset = "0x20")]
		public UILabel m_ItemNameLabel;

		// Token: 0x0400A34B RID: 41803
		[Token(Token = "0x400A34B")]
		[FieldOffset(Offset = "0x28")]
		public UISprite m_ItemIconSprite;

		// Token: 0x0400A34C RID: 41804
		[Token(Token = "0x400A34C")]
		[FieldOffset(Offset = "0x30")]
		public UISprite m_ItemBigIconSprite;

		// Token: 0x0400A34D RID: 41805
		[Token(Token = "0x400A34D")]
		[FieldOffset(Offset = "0x38")]
		public UILabel m_QuantityLabel;

		// Token: 0x0400A34E RID: 41806
		[Token(Token = "0x400A34E")]
		[FieldOffset(Offset = "0x40")]
		public UILabel m_VoucherLabel;

		// Token: 0x0400A34F RID: 41807
		[Token(Token = "0x400A34F")]
		[FieldOffset(Offset = "0x48")]
		public bool m_QuantityIgnoreOne;

		// Token: 0x0400A350 RID: 41808
		[Token(Token = "0x400A350")]
		[FieldOffset(Offset = "0x50")]
		public UILabel m_QuantityLimitLabel;

		// Token: 0x0400A351 RID: 41809
		[Token(Token = "0x400A351")]
		[FieldOffset(Offset = "0x58")]
		public UIWidget[] m_QualityPerformances;

		// Token: 0x0400A352 RID: 41810
		[Token(Token = "0x400A352")]
		[FieldOffset(Offset = "0x60")]
		public UISprite m_TreasureBoxSprite;

		// Token: 0x0400A353 RID: 41811
		[Token(Token = "0x400A353")]
		[FieldOffset(Offset = "0x68")]
		public UISprite m_BackpackSprite;

		// Token: 0x0400A354 RID: 41812
		[Token(Token = "0x400A354")]
		[FieldOffset(Offset = "0x70")]
		public UISprite m_ParachuteSprite;

		// Token: 0x0400A355 RID: 41813
		[Token(Token = "0x400A355")]
		[FieldOffset(Offset = "0x78")]
		public UISprite m_HeadPicSprite;

		// Token: 0x0400A356 RID: 41814
		[Token(Token = "0x400A356")]
		[FieldOffset(Offset = "0x80")]
		public UISprite m_CallSignSprite;

		// Token: 0x0400A357 RID: 41815
		[Token(Token = "0x400A357")]
		[FieldOffset(Offset = "0x88")]
		public UISprite m_BundleSprite;

		// Token: 0x0400A358 RID: 41816
		[Token(Token = "0x400A358")]
		[FieldOffset(Offset = "0x90")]
		public UISprite m_ClothesSprite;

		// Token: 0x0400A359 RID: 41817
		[Token(Token = "0x400A359")]
		[FieldOffset(Offset = "0x98")]
		public UISprite m_SurfboardSprite;

		// Token: 0x0400A35A RID: 41818
		[Token(Token = "0x400A35A")]
		[FieldOffset(Offset = "0xA0")]
		public UISprite m_GrowthCardSprite;

		// Token: 0x0400A35B RID: 41819
		[Token(Token = "0x400A35B")]
		[FieldOffset(Offset = "0xA8")]
		public UISprite m_DebrisSprite;

		// Token: 0x0400A35C RID: 41820
		[Token(Token = "0x400A35C")]
		[FieldOffset(Offset = "0xB0")]
		public UISprite m_VirtualSprite;

		// Token: 0x0400A35D RID: 41821
		[Token(Token = "0x400A35D")]
		[FieldOffset(Offset = "0xB8")]
		public UISprite m_WeaponSprite;

		// Token: 0x0400A35E RID: 41822
		[Token(Token = "0x400A35E")]
		[FieldOffset(Offset = "0xC0")]
		public UISprite m_SuitWeaponSprite;

		// Token: 0x0400A35F RID: 41823
		[Token(Token = "0x400A35F")]
		[FieldOffset(Offset = "0xC8")]
		public UISprite m_VehicleSprite;

		// Token: 0x0400A360 RID: 41824
		[Token(Token = "0x400A360")]
		[FieldOffset(Offset = "0xD0")]
		public UISprite m_AvatarSprite;

		// Token: 0x0400A361 RID: 41825
		[Token(Token = "0x400A361")]
		[FieldOffset(Offset = "0xD8")]
		public UISprite m_EmoteSprite;

		// Token: 0x0400A362 RID: 41826
		[Token(Token = "0x400A362")]
		[FieldOffset(Offset = "0xE0")]
		public UISprite m_PetAnimSprite;

		// Token: 0x0400A363 RID: 41827
		[Token(Token = "0x400A363")]
		[FieldOffset(Offset = "0xE8")]
		public UISprite m_VoucherSprite;

		// Token: 0x0400A364 RID: 41828
		[Token(Token = "0x400A364")]
		[FieldOffset(Offset = "0xF0")]
		public UISprite m_RedEnvelopeSprite;

		// Token: 0x0400A365 RID: 41829
		[Token(Token = "0x400A365")]
		[FieldOffset(Offset = "0xF8")]
		public UISprite m_FlightSprite;

		// Token: 0x0400A366 RID: 41830
		[Token(Token = "0x400A366")]
		[FieldOffset(Offset = "0x100")]
		public GameObject m_FlowLight;

		// Token: 0x0400A367 RID: 41831
		[Token(Token = "0x400A367")]
		[FieldOffset(Offset = "0x108")]
		public bool m_UseBigIcon;

		// Token: 0x0400A368 RID: 41832
		[Token(Token = "0x400A368")]
		[FieldOffset(Offset = "0x110")]
		private UISprite itemSprite;

		// Token: 0x0400A369 RID: 41833
		[Token(Token = "0x400A369")]
		[FieldOffset(Offset = "0x118")]
		public List<UISprite> m_ShadowSpriteList;
	}
}
