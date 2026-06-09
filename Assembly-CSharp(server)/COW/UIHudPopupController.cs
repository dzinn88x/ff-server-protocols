using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001934 RID: 6452
	[Token(Token = "0x2001934")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F5C14", Offset = "0x10F5C14")]
	internal class UIHudPopupController : UIBaseController
	{
		// Token: 0x060082B2 RID: 33458 RVA: 0x00023808 File Offset: 0x00021A08
		[Token(Token = "0x60082B2")]
		[Address(RVA = "0x1D85068", Offset = "0x1D85068", VA = "0x7BBC585068")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060082B3 RID: 33459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60082B3")]
		[Address(RVA = "0x1D850B8", Offset = "0x1D850B8", VA = "0x7BBC5850B8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060082B4 RID: 33460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60082B4")]
		[Address(RVA = "0x1D85134", Offset = "0x1D85134", VA = "0x7BBC585134", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x060082B5 RID: 33461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60082B5")]
		[Address(RVA = "0x1D8513C", Offset = "0x1D8513C", VA = "0x7BBC58513C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060082B6 RID: 33462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60082B6")]
		[Address(RVA = "0x1D85204", Offset = "0x1D85204", VA = "0x7BBC585204")]
		public void SetMessage(string message, float duration)
		{
		}

		// Token: 0x060082B7 RID: 33463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60082B7")]
		[Address(RVA = "0x1D8543C", Offset = "0x1D8543C", VA = "0x7BBC58543C")]
		public void SetDepth(int depth)
		{
		}

		// Token: 0x060082B8 RID: 33464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60082B8")]
		[Address(RVA = "0x1D854C0", Offset = "0x1D854C0", VA = "0x7BBC5854C0")]
		private void AutoHide()
		{
		}

		// Token: 0x060082B9 RID: 33465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60082B9")]
		[Address(RVA = "0x1D85164", Offset = "0x1D85164", VA = "0x7BBC585164")]
		private void CancelDelayCall()
		{
		}

		// Token: 0x060082BA RID: 33466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60082BA")]
		[Address(RVA = "0x1D85568", Offset = "0x1D85568", VA = "0x7BBC585568", Slot = "20")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x060082BB RID: 33467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60082BB")]
		[Address(RVA = "0x1D85590", Offset = "0x1D85590", VA = "0x7BBC585590")]
		public UIHudPopupController()
		{
		}

		// Token: 0x040093D8 RID: 37848
		[Token(Token = "0x40093D8")]
		[FieldOffset(Offset = "0x58")]
		private UIHudPopupView m_View;

		// Token: 0x040093D9 RID: 37849
		[Token(Token = "0x40093D9")]
		[FieldOffset(Offset = "0x60")]
		private uint m_DelayCallID;

		// Token: 0x040093DA RID: 37850
		[Token(Token = "0x40093DA")]
		[FieldOffset(Offset = "0x68")]
		private Animator m_Animator;
	}
}
