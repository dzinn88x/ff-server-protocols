using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020014AA RID: 5290
	[Token(Token = "0x20014AA")]
	public class CommonRewardWindowStyleBaseController : UIBaseController
	{
		// Token: 0x060059C1 RID: 22977 RVA: 0x0001A670 File Offset: 0x00018870
		[Token(Token = "0x60059C1")]
		[Address(RVA = "0x15FC9B0", Offset = "0x15FC9B0", VA = "0x7BBBDFC9B0")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060059C2 RID: 22978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059C2")]
		[Address(RVA = "0x15FCA00", Offset = "0x15FCA00", VA = "0x7BBBDFCA00", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060059C3 RID: 22979 RVA: 0x0001A688 File Offset: 0x00018888
		[Token(Token = "0x60059C3")]
		[Address(RVA = "0x15FCAF8", Offset = "0x15FCAF8", VA = "0x7BBBDFCAF8")]
		public Vector3 GetTopPos()
		{
			return default(Vector3);
		}

		// Token: 0x060059C4 RID: 22980 RVA: 0x0001A6A0 File Offset: 0x000188A0
		[Token(Token = "0x60059C4")]
		[Address(RVA = "0x15FCB04", Offset = "0x15FCB04", VA = "0x7BBBDFCB04")]
		public Vector3 GetBottomPos()
		{
			return default(Vector3);
		}

		// Token: 0x060059C5 RID: 22981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059C5")]
		[Address(RVA = "0x15FCB10", Offset = "0x15FCB10", VA = "0x7BBBDFCB10", Slot = "28")]
		protected virtual string GetGuideBtnSpriteName()
		{
			return null;
		}

		// Token: 0x060059C6 RID: 22982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059C6")]
		[Address(RVA = "0x15FCB58", Offset = "0x15FCB58", VA = "0x7BBBDFCB58", Slot = "29")]
		protected virtual string GetNormalBtnSpriteName()
		{
			return null;
		}

		// Token: 0x060059C7 RID: 22983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059C7")]
		[Address(RVA = "0x15FCBA0", Offset = "0x15FCBA0", VA = "0x7BBBDFCBA0")]
		public void AdjustBtnStyle(bool GuideOnLeft = false)
		{
		}

		// Token: 0x060059C8 RID: 22984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059C8")]
		[Address(RVA = "0x15FCE6C", Offset = "0x15FCE6C", VA = "0x7BBBDFCE6C")]
		public CommonRewardWindowStyleBaseController()
		{
		}

		// Token: 0x04007D1C RID: 32028
		[Token(Token = "0x4007D1C")]
		[FieldOffset(Offset = "0x58")]
		public CommonRewardWnd_BGStyle_CommonView m_View;

		// Token: 0x04007D1D RID: 32029
		[Token(Token = "0x4007D1D")]
		[FieldOffset(Offset = "0x60")]
		private Vector3 TopPos;

		// Token: 0x04007D1E RID: 32030
		[Token(Token = "0x4007D1E")]
		[FieldOffset(Offset = "0x6C")]
		private Vector3 BottomPos;
	}
}
