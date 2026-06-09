using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001461 RID: 5217
	[Token(Token = "0x2001461")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10ECC68", Offset = "0x10ECC68")]
	public class UIHUDBountyBossInfoController : UIBaseController
	{
		// Token: 0x060057B9 RID: 22457 RVA: 0x00019F38 File Offset: 0x00018138
		[Token(Token = "0x60057B9")]
		[Address(RVA = "0x16B5F3C", Offset = "0x16B5F3C", VA = "0x7BBBEB5F3C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060057BA RID: 22458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057BA")]
		[Address(RVA = "0x16B5F8C", Offset = "0x16B5F8C", VA = "0x7BBBEB5F8C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060057BB RID: 22459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057BB")]
		[Address(RVA = "0x16B61AC", Offset = "0x16B61AC", VA = "0x7BBBEB61AC", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060057BC RID: 22460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057BC")]
		[Address(RVA = "0x16B62D4", Offset = "0x16B62D4", VA = "0x7BBBEB62D4")]
		private void OnPhaseChange(GEvent gEvent)
		{
		}

		// Token: 0x060057BD RID: 22461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057BD")]
		[Address(RVA = "0x16B6608", Offset = "0x16B6608", VA = "0x7BBBEB6608")]
		private void DelayHideObject(GameObject obj, float t, bool isHide = true)
		{
		}

		// Token: 0x060057BE RID: 22462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057BE")]
		[Address(RVA = "0x16B6728", Offset = "0x16B6728", VA = "0x7BBBEB6728")]
		private void LateUpdate()
		{
		}

		// Token: 0x060057BF RID: 22463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057BF")]
		[Address(RVA = "0x16B6980", Offset = "0x16B6980", VA = "0x7BBBEB6980")]
		private void OnBossEnhance(params object[] param)
		{
		}

		// Token: 0x060057C0 RID: 22464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057C0")]
		[Address(RVA = "0x16B69C4", Offset = "0x16B69C4", VA = "0x7BBBEB69C4")]
		public UIHUDBountyBossInfoController()
		{
		}

		// Token: 0x04007BE0 RID: 31712
		[Token(Token = "0x4007BE0")]
		[FieldOffset(Offset = "0x58")]
		private UIHUDBountyBOSSInfoView m_View;

		// Token: 0x04007BE1 RID: 31713
		[Token(Token = "0x4007BE1")]
		[FieldOffset(Offset = "0x60")]
		private Camera m_FollowCameraComponent;

		// Token: 0x02001462 RID: 5218
		[Token(Token = "0x2001462")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10ECCA0", Offset = "0x10ECCA0")]
		private sealed class <>c__DisplayClass6_0
		{
			// Token: 0x060057C1 RID: 22465 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60057C1")]
			[Address(RVA = "0x16B6720", Offset = "0x16B6720", VA = "0x7BBBEB6720")]
			public <>c__DisplayClass6_0()
			{
			}

			// Token: 0x060057C2 RID: 22466 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60057C2")]
			[Address(RVA = "0x16B69CC", Offset = "0x16B69CC", VA = "0x7BBBEB69CC")]
			internal void <DelayHideObject>b__0()
			{
			}

			// Token: 0x04007BE2 RID: 31714
			[Token(Token = "0x4007BE2")]
			[FieldOffset(Offset = "0x10")]
			public GameObject obj;

			// Token: 0x04007BE3 RID: 31715
			[Token(Token = "0x4007BE3")]
			[FieldOffset(Offset = "0x18")]
			public bool isHide;
		}
	}
}
