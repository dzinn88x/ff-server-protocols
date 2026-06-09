using System;
using COW.GamePlay;
using COW.HUD;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001924 RID: 6436
	[Token(Token = "0x2001924")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F5A0C", Offset = "0x10F5A0C")]
	internal class UIHudPetNameController : UIHudEntityPosControllerBase
	{
		// Token: 0x060081F3 RID: 33267 RVA: 0x00023670 File Offset: 0x00021870
		[Token(Token = "0x60081F3")]
		[Address(RVA = "0x1D6DE68", Offset = "0x1D6DE68", VA = "0x7BBC56DE68")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060081F4 RID: 33268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081F4")]
		[Address(RVA = "0x1D6DEB8", Offset = "0x1D6DEB8", VA = "0x7BBC56DEB8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060081F5 RID: 33269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081F5")]
		[Address(RVA = "0x1D6DF30", Offset = "0x1D6DF30", VA = "0x7BBC56DF30", Slot = "29")]
		protected override void OnRegisterEvents()
		{
		}

		// Token: 0x060081F6 RID: 33270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081F6")]
		[Address(RVA = "0x1D6E0F8", Offset = "0x1D6E0F8", VA = "0x7BBC56E0F8", Slot = "30")]
		protected override void OnUnRegisterEvents()
		{
		}

		// Token: 0x060081F7 RID: 33271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081F7")]
		[Address(RVA = "0x1D6E2C0", Offset = "0x1D6E2C0", VA = "0x7BBC56E2C0", Slot = "31")]
		public override void BindTarget(Entity e)
		{
		}

		// Token: 0x060081F8 RID: 33272 RVA: 0x00023688 File Offset: 0x00021888
		[Token(Token = "0x60081F8")]
		[Address(RVA = "0x1D6E51C", Offset = "0x1D6E51C", VA = "0x7BBC56E51C", Slot = "35")]
		protected override Vector3 GetRefPos(Entity e)
		{
			return default(Vector3);
		}

		// Token: 0x060081F9 RID: 33273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081F9")]
		[Address(RVA = "0x1D6E63C", Offset = "0x1D6E63C", VA = "0x7BBC56E63C", Slot = "28")]
		protected override void UpdateTargetPlayer()
		{
		}

		// Token: 0x060081FA RID: 33274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081FA")]
		[Address(RVA = "0x1D6E664", Offset = "0x1D6E664", VA = "0x7BBC56E664")]
		private void UpdateHideForRole()
		{
		}

		// Token: 0x060081FB RID: 33275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081FB")]
		[Address(RVA = "0x1D6E83C", Offset = "0x1D6E83C", VA = "0x7BBC56E83C")]
		private void OnObserverChange(params object[] data)
		{
		}

		// Token: 0x060081FC RID: 33276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081FC")]
		[Address(RVA = "0x1D6E88C", Offset = "0x1D6E88C", VA = "0x7BBC56E88C")]
		private void OnPetDelete(params object[] data)
		{
		}

		// Token: 0x060081FD RID: 33277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081FD")]
		[Address(RVA = "0x1D6E998", Offset = "0x1D6E998", VA = "0x7BBC56E998")]
		private void OnPetShowHide(params object[] data)
		{
		}

		// Token: 0x060081FE RID: 33278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081FE")]
		[Address(RVA = "0x1D6E518", Offset = "0x1D6E518", VA = "0x7BBC56E518")]
		private void UpdateColor()
		{
		}

		// Token: 0x060081FF RID: 33279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081FF")]
		[Address(RVA = "0x1D6EAEC", Offset = "0x1D6EAEC", VA = "0x7BBC56EAEC")]
		private void UpdateColor(bool isLocalPlayer)
		{
		}

		// Token: 0x06008200 RID: 33280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008200")]
		[Address(RVA = "0x1D6E4F4", Offset = "0x1D6E4F4", VA = "0x7BBC56E4F4")]
		private void UpdateShowHide()
		{
		}

		// Token: 0x06008201 RID: 33281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008201")]
		[Address(RVA = "0x1D6EBA8", Offset = "0x1D6EBA8", VA = "0x7BBC56EBA8")]
		public UIHudPetNameController()
		{
		}

		// Token: 0x04009364 RID: 37732
		[Token(Token = "0x4009364")]
		[FieldOffset(Offset = "0xE0")]
		private UIHudPetNameView m_View;

		// Token: 0x04009365 RID: 37733
		[Token(Token = "0x4009365")]
		[FieldOffset(Offset = "0xE8")]
		private {QAb\u0082~u m_PlayerID;

		// Token: 0x04009366 RID: 37734
		[Token(Token = "0x4009366")]
		[FieldOffset(Offset = "0x100")]
		private bool m_ShowForRole;

		// Token: 0x04009367 RID: 37735
		[Token(Token = "0x4009367")]
		[FieldOffset(Offset = "0x101")]
		private bool m_PetShowing;
	}
}
