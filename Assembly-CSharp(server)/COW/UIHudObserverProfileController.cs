using System;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200191F RID: 6431
	[Token(Token = "0x200191F")]
	internal class UIHudObserverProfileController : UIBaseController
	{
		// Token: 0x060081C9 RID: 33225 RVA: 0x00023628 File Offset: 0x00021828
		[Token(Token = "0x60081C9")]
		[Address(RVA = "0x17BC8C4", Offset = "0x17BC8C4", VA = "0x7BBBFBC8C4")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060081CA RID: 33226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081CA")]
		[Address(RVA = "0x17BC914", Offset = "0x17BC914", VA = "0x7BBBFBC914", Slot = "19")]
		protected override void OnVisibilityChanged()
		{
		}

		// Token: 0x060081CB RID: 33227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081CB")]
		[Address(RVA = "0x17BCDF4", Offset = "0x17BCDF4", VA = "0x7BBBFBCDF4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060081CC RID: 33228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081CC")]
		[Address(RVA = "0x17BD878", Offset = "0x17BD878", VA = "0x7BBBFBD878", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060081CD RID: 33229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081CD")]
		[Address(RVA = "0x17BDAD4", Offset = "0x17BDAD4", VA = "0x7BBBFBDAD4")]
		private void OnObserverSwitch(object[] data)
		{
		}

		// Token: 0x060081CE RID: 33230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081CE")]
		[Address(RVA = "0x17BE540", Offset = "0x17BE540", VA = "0x7BBBFBE540")]
		private void OnLikeCountChanged(params object[] data)
		{
		}

		// Token: 0x060081CF RID: 33231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081CF")]
		[Address(RVA = "0x17BE610", Offset = "0x17BE610", VA = "0x7BBBFBE610")]
		private void OnDropClick()
		{
		}

		// Token: 0x060081D0 RID: 33232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081D0")]
		[Address(RVA = "0x17BE710", Offset = "0x17BE710", VA = "0x7BBBFBE710")]
		private void onReportClick()
		{
		}

		// Token: 0x060081D1 RID: 33233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081D1")]
		[Address(RVA = "0x17BE8FC", Offset = "0x17BE8FC", VA = "0x7BBBFBE8FC")]
		private void OnReportCheatSent(object[] param)
		{
		}

		// Token: 0x060081D2 RID: 33234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081D2")]
		[Address(RVA = "0x17BE9A4", Offset = "0x17BE9A4", VA = "0x7BBBFBE9A4")]
		private void OnLikeClick()
		{
		}

		// Token: 0x060081D3 RID: 33235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081D3")]
		[Address(RVA = "0x17BEC20", Offset = "0x17BEC20", VA = "0x7BBBFBEC20")]
		private void OnAddFriendClick()
		{
		}

		// Token: 0x060081D4 RID: 33236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081D4")]
		[Address(RVA = "0x17BEE1C", Offset = "0x17BEE1C", VA = "0x7BBBFBEE1C")]
		private void OnReviveClick()
		{
		}

		// Token: 0x060081D5 RID: 33237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081D5")]
		[Address(RVA = "0x17BE35C", Offset = "0x17BE35C", VA = "0x7BBBFBE35C")]
		private void StartReviveCountDown()
		{
		}

		// Token: 0x060081D6 RID: 33238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081D6")]
		[Address(RVA = "0x17BEED4", Offset = "0x17BEED4", VA = "0x7BBBFBEED4")]
		private void OnObserverInfoListVisibleChanged(object[] data)
		{
		}

		// Token: 0x060081D7 RID: 33239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081D7")]
		[Address(RVA = "0x17BEF7C", Offset = "0x17BEF7C", VA = "0x7BBBFBEF7C")]
		private void OnTrainingZoneChanged(params object[] data)
		{
		}

		// Token: 0x060081D8 RID: 33240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081D8")]
		[Address(RVA = "0x17BF05C", Offset = "0x17BF05C", VA = "0x7BBBFBF05C")]
		public UIHudObserverProfileController()
		{
		}

		// Token: 0x04009354 RID: 37716
		[Token(Token = "0x4009354")]
		[FieldOffset(Offset = "0x58")]
		private UIHudObserverProfileView m_View;

		// Token: 0x04009355 RID: 37717
		[Token(Token = "0x4009355")]
		[FieldOffset(Offset = "0x60")]
		private UIBaseProfileInfoController m_Profile;

		// Token: 0x04009356 RID: 37718
		[Token(Token = "0x4009356")]
		[FieldOffset(Offset = "0x68")]
		private {QAb\u0082~u m_TargetPlayerID;

		// Token: 0x04009357 RID: 37719
		[Token(Token = "0x4009357")]
		[FieldOffset(Offset = "0x80")]
		private ulong m_TargetUserID;

		// Token: 0x04009358 RID: 37720
		[Token(Token = "0x4009358")]
		[FieldOffset(Offset = "0x88")]
		private string m_TargetPlayerName;

		// Token: 0x04009359 RID: 37721
		[Token(Token = "0x4009359")]
		[FieldOffset(Offset = "0x90")]
		private UITimeLabelHelper m_TimeHelper;

		// Token: 0x0400935A RID: 37722
		[Token(Token = "0x400935A")]
		[FieldOffset(Offset = "0x98")]
		private bool m_ShowReviveCountDown;
	}
}
