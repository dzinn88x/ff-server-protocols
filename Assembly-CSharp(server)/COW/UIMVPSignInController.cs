using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020013A6 RID: 5030
	[Token(Token = "0x20013A6")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EB9E0", Offset = "0x10EB9E0")]
	internal class UIMVPSignInController : UIPopupWindowController, IUIModelDataChangeObserver
	{
		// Token: 0x060051B1 RID: 20913 RVA: 0x000189F0 File Offset: 0x00016BF0
		[Token(Token = "0x60051B1")]
		[Address(RVA = "0x1CD7D64", Offset = "0x1CD7D64", VA = "0x7BBC4D7D64")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060051B2 RID: 20914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051B2")]
		[Address(RVA = "0x1CD7DB4", Offset = "0x1CD7DB4", VA = "0x7BBC4D7DB4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060051B3 RID: 20915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051B3")]
		[Address(RVA = "0x1CD8710", Offset = "0x1CD8710", VA = "0x7BBC4D8710", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060051B4 RID: 20916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051B4")]
		[Address(RVA = "0x1CD8810", Offset = "0x1CD8810", VA = "0x7BBC4D8810")]
		private void Update()
		{
		}

		// Token: 0x060051B5 RID: 20917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051B5")]
		[Address(RVA = "0x1CD8164", Offset = "0x1CD8164", VA = "0x7BBC4D8164")]
		private void RefreshBoxView()
		{
		}

		// Token: 0x060051B6 RID: 20918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051B6")]
		[Address(RVA = "0x1CD8AEC", Offset = "0x1CD8AEC", VA = "0x7BBC4D8AEC")]
		private void OnFinishMVPSignIn()
		{
		}

		// Token: 0x060051B7 RID: 20919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051B7")]
		[Address(RVA = "0x1CD8C24", Offset = "0x1CD8C24", VA = "0x7BBC4D8C24")]
		private void AnimEvtHandler(params object[] data)
		{
		}

		// Token: 0x060051B8 RID: 20920 RVA: 0x00018A08 File Offset: 0x00016C08
		[Token(Token = "0x60051B8")]
		[Address(RVA = "0x1CD8E24", Offset = "0x1CD8E24", VA = "0x7BBC4D8E24", Slot = "41")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x060051B9 RID: 20921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051B9")]
		[Address(RVA = "0x1CD8E88", Offset = "0x1CD8E88", VA = "0x7BBC4D8E88", Slot = "40")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x060051BA RID: 20922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051BA")]
		[Address(RVA = "0x1CD8F64", Offset = "0x1CD8F64", VA = "0x7BBC4D8F64")]
		public UIMVPSignInController()
		{
		}

		// Token: 0x040077F9 RID: 30713
		[Token(Token = "0x40077F9")]
		[FieldOffset(Offset = "0x98")]
		private UIMVPSignInView m_View;

		// Token: 0x040077FA RID: 30714
		[Token(Token = "0x40077FA")]
		[FieldOffset(Offset = "0xA0")]
		private UIModelMVP m_ModelMVP;

		// Token: 0x040077FB RID: 30715
		[Token(Token = "0x40077FB")]
		[FieldOffset(Offset = "0xA8")]
		private UIModelActivity m_ModelActivity;

		// Token: 0x040077FC RID: 30716
		[Token(Token = "0x40077FC")]
		[FieldOffset(Offset = "0xB0")]
		private float minDis;

		// Token: 0x040077FD RID: 30717
		[Token(Token = "0x40077FD")]
		[FieldOffset(Offset = "0xB4")]
		private Vector2 m_StartPos;

		// Token: 0x040077FE RID: 30718
		[Token(Token = "0x40077FE")]
		[FieldOffset(Offset = "0xBC")]
		private bool m_HasSignIn;
	}
}
