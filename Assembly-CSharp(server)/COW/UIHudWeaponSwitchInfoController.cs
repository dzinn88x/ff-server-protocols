using System;
using System.Text;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001994 RID: 6548
	[Token(Token = "0x2001994")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F69FC", Offset = "0x10F69FC")]
	internal class UIHudWeaponSwitchInfoController : UIBaseController
	{
		// Token: 0x060085CC RID: 34252 RVA: 0x00024480 File Offset: 0x00022680
		[Token(Token = "0x60085CC")]
		[Address(RVA = "0x1D0E0A8", Offset = "0x1D0E0A8", VA = "0x7BBC50E0A8")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x170009B2 RID: 2482
		// (get) Token: 0x060085CD RID: 34253 RVA: 0x00024498 File Offset: 0x00022698
		// (set) Token: 0x060085CE RID: 34254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009B2")]
		public ByGSUuj EquipSlot
		{
			[Token(Token = "0x60085CD")]
			[Address(RVA = "0x1D0E0F8", Offset = "0x1D0E0F8", VA = "0x7BBC50E0F8")]
			get
			{
				return ByGSUuj.PrimaryWeapon1;
			}
			[Token(Token = "0x60085CE")]
			[Address(RVA = "0x1D0E100", Offset = "0x1D0E100", VA = "0x7BBC50E100")]
			set
			{
			}
		}

		// Token: 0x060085CF RID: 34255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60085CF")]
		[Address(RVA = "0x1D0E108", Offset = "0x1D0E108", VA = "0x7BBC50E108")]
		private void Start()
		{
		}

		// Token: 0x060085D0 RID: 34256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60085D0")]
		[Address(RVA = "0x1D0E340", Offset = "0x1D0E340", VA = "0x7BBC50E340", Slot = "9")]
		protected override void Awake()
		{
		}

		// Token: 0x060085D1 RID: 34257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60085D1")]
		[Address(RVA = "0x1D0E348", Offset = "0x1D0E348", VA = "0x7BBC50E348", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060085D2 RID: 34258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60085D2")]
		[Address(RVA = "0x1D0E620", Offset = "0x1D0E620", VA = "0x7BBC50E620")]
		private void ShowLevelUpGoldFX(bool show)
		{
		}

		// Token: 0x060085D3 RID: 34259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60085D3")]
		[Address(RVA = "0x1D0E7C8", Offset = "0x1D0E7C8", VA = "0x7BBC50E7C8", Slot = "19")]
		protected override void OnVisibilityChanged()
		{
		}

		// Token: 0x060085D4 RID: 34260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60085D4")]
		[Address(RVA = "0x1D0EBE8", Offset = "0x1D0EBE8", VA = "0x7BBC50EBE8")]
		private void Update()
		{
		}

		// Token: 0x060085D5 RID: 34261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60085D5")]
		[Address(RVA = "0x1D0FF14", Offset = "0x1D0FF14", VA = "0x7BBC50FF14")]
		public void ShowGoldLevelup()
		{
		}

		// Token: 0x060085D6 RID: 34262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60085D6")]
		[Address(RVA = "0x1D0FF54", Offset = "0x1D0FF54", VA = "0x7BBC50FF54")]
		public void ShowLevelUp()
		{
		}

		// Token: 0x060085D7 RID: 34263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60085D7")]
		[Address(RVA = "0x1D0FF94", Offset = "0x1D0FF94", VA = "0x7BBC50FF94")]
		public void ShowLevelDown()
		{
		}

		// Token: 0x060085D8 RID: 34264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60085D8")]
		[Address(RVA = "0x1D0E824", Offset = "0x1D0E824", VA = "0x7BBC50E824")]
		private void ShowLevelUpOrDownEffect(bool isUp, bool show)
		{
		}

		// Token: 0x060085D9 RID: 34265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60085D9")]
		[Address(RVA = "0x1D0FE10", Offset = "0x1D0FE10", VA = "0x7BBC50FE10")]
		private void UpdateLevelUpOrDownEffectHiding()
		{
		}

		// Token: 0x060085DA RID: 34266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60085DA")]
		[Address(RVA = "0x1D0E124", Offset = "0x1D0E124", VA = "0x7BBC50E124")]
		private void SetDefaultIcon()
		{
		}

		// Token: 0x060085DB RID: 34267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60085DB")]
		[Address(RVA = "0x1D0FFD4", Offset = "0x1D0FFD4", VA = "0x7BBC50FFD4", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060085DC RID: 34268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60085DC")]
		[Address(RVA = "0x1D10094", Offset = "0x1D10094", VA = "0x7BBC510094")]
		private void OnCanCombineChanged(object[] param)
		{
		}

		// Token: 0x060085DD RID: 34269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60085DD")]
		[Address(RVA = "0x1D102C0", Offset = "0x1D102C0", VA = "0x7BBC5102C0")]
		private void OnSwitchWeaponClick()
		{
		}

		// Token: 0x060085DE RID: 34270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60085DE")]
		[Address(RVA = "0x1D10400", Offset = "0x1D10400", VA = "0x7BBC510400")]
		public void TweakUIForHyakki(int width)
		{
		}

		// Token: 0x060085DF RID: 34271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60085DF")]
		[Address(RVA = "0x1D104B8", Offset = "0x1D104B8", VA = "0x7BBC5104B8")]
		public UIHudWeaponSwitchInfoController()
		{
		}

		// Token: 0x0400953E RID: 38206
		[Token(Token = "0x400953E")]
		[FieldOffset(Offset = "0x58")]
		public UIHudWeaponSwitchInfoView m_View;

		// Token: 0x0400953F RID: 38207
		[Token(Token = "0x400953F")]
		[FieldOffset(Offset = "0x60")]
		private ByGSUuj m_EquipSlot;

		// Token: 0x04009540 RID: 38208
		[Token(Token = "0x4009540")]
		[FieldOffset(Offset = "0x64")]
		private int m_LastAmmoCapacity;

		// Token: 0x04009541 RID: 38209
		[Token(Token = "0x4009541")]
		[FieldOffset(Offset = "0x68")]
		private int m_LastAmmoLeft;

		// Token: 0x04009542 RID: 38210
		[Token(Token = "0x4009542")]
		[FieldOffset(Offset = "0x6C")]
		private int m_LastAmmoLeftInClip;

		// Token: 0x04009543 RID: 38211
		[Token(Token = "0x4009543")]
		[FieldOffset(Offset = "0x70")]
		private int m_LastAmmoLeftInBag;

		// Token: 0x04009544 RID: 38212
		[Token(Token = "0x4009544")]
		[FieldOffset(Offset = "0x74")]
		private bool m_LastComine;

		// Token: 0x04009545 RID: 38213
		[Token(Token = "0x4009545")]
		[FieldOffset(Offset = "0x78")]
		private AHtazwI m_LastWeaponItem;

		// Token: 0x04009546 RID: 38214
		[Token(Token = "0x4009546")]
		[FieldOffset(Offset = "0x80")]
		private bool m_LastCombined;

		// Token: 0x04009547 RID: 38215
		[Token(Token = "0x4009547")]
		[FieldOffset(Offset = "0x88")]
		private UILabel m_MaxAmmo;

		// Token: 0x04009548 RID: 38216
		[Token(Token = "0x4009548")]
		[FieldOffset(Offset = "0x90")]
		private UISprite m_InfiniteAmmo;

		// Token: 0x04009549 RID: 38217
		[Token(Token = "0x4009549")]
		[FieldOffset(Offset = "0x98")]
		private UIProgressBar m_AmmonStatusBar;

		// Token: 0x0400954A RID: 38218
		[Token(Token = "0x400954A")]
		[FieldOffset(Offset = "0xA0")]
		private StringBuilder m_Sb;

		// Token: 0x0400954B RID: 38219
		[Token(Token = "0x400954B")]
		[FieldOffset(Offset = "0xA8")]
		private bool m_IsHyakkiMode;

		// Token: 0x0400954C RID: 38220
		[Token(Token = "0x400954C")]
		[FieldOffset(Offset = "0xB0")]
		private GameObject m_FXLevelUpGold;

		// Token: 0x0400954D RID: 38221
		[Token(Token = "0x400954D")]
		[FieldOffset(Offset = "0xB8")]
		private float m_FXLevelUpOrDownLastTime;

		// Token: 0x0400954E RID: 38222
		[Token(Token = "0x400954E")]
		[FieldOffset(Offset = "0xBC")]
		private float m_FXLevelUpEndTime;

		// Token: 0x0400954F RID: 38223
		[Token(Token = "0x400954F")]
		[FieldOffset(Offset = "0xC0")]
		private float m_FXLevelDownEndTime;

		// Token: 0x04009550 RID: 38224
		[Token(Token = "0x4009550")]
		[FieldOffset(Offset = "0xC8")]
		private CommonParticleEffect m_FXLevelUp;

		// Token: 0x04009551 RID: 38225
		[Token(Token = "0x4009551")]
		[FieldOffset(Offset = "0xD0")]
		private CommonParticleEffect m_FXLevelDown;

		// Token: 0x04009552 RID: 38226
		[Token(Token = "0x4009552")]
		[FieldOffset(Offset = "0xD8")]
		private Quaternion NormalPrimaryIconRot;

		// Token: 0x04009553 RID: 38227
		[Token(Token = "0x4009553")]
		[FieldOffset(Offset = "0xE8")]
		private Quaternion CombinedPrimaryIconRot;
	}
}
