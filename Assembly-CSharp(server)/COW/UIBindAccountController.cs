using System;
using System.Collections.Generic;
using GarenaMSDK;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200155A RID: 5466
	[Token(Token = "0x200155A")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EE5E4", Offset = "0x10EE5E4")]
	public class UIBindAccountController : UIPopupWindowController, IUIModelDataChangeObserver
	{
		// Token: 0x06005E8D RID: 24205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E8D")]
		[Address(RVA = "0x142FE4C", Offset = "0x142FE4C", VA = "0x7BBBC2FE4C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005E8E RID: 24206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E8E")]
		[Address(RVA = "0x14302C8", Offset = "0x14302C8", VA = "0x7BBBC302C8")]
		private void InitPlatformBtns()
		{
		}

		// Token: 0x06005E8F RID: 24207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E8F")]
		[Address(RVA = "0x1430C94", Offset = "0x1430C94", VA = "0x7BBBC30C94", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06005E90 RID: 24208 RVA: 0x0001B618 File Offset: 0x00019818
		[Token(Token = "0x6005E90")]
		[Address(RVA = "0x1430D3C", Offset = "0x1430D3C", VA = "0x7BBBC30D3C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005E91 RID: 24209 RVA: 0x0001B630 File Offset: 0x00019830
		[Token(Token = "0x6005E91")]
		[Address(RVA = "0x1430D8C", Offset = "0x1430D8C", VA = "0x7BBBC30D8C", Slot = "41")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06005E92 RID: 24210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E92")]
		[Address(RVA = "0x1430DD0", Offset = "0x1430DD0", VA = "0x7BBBC30DD0", Slot = "40")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06005E93 RID: 24211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E93")]
		[Address(RVA = "0x1430720", Offset = "0x1430720", VA = "0x7BBBC30720")]
		private void SetCDNTexture()
		{
		}

		// Token: 0x06005E94 RID: 24212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E94")]
		[Address(RVA = "0x1430874", Offset = "0x1430874", VA = "0x7BBBC30874")]
		public void ShowAwardItem()
		{
		}

		// Token: 0x06005E95 RID: 24213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E95")]
		[Address(RVA = "0x1430F18", Offset = "0x1430F18", VA = "0x7BBBC30F18")]
		private void Bind(PlatformType platform)
		{
		}

		// Token: 0x06005E96 RID: 24214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E96")]
		[Address(RVA = "0x1430FD4", Offset = "0x1430FD4", VA = "0x7BBBC30FD4")]
		private void BindGarena(PlatformType platform)
		{
		}

		// Token: 0x06005E97 RID: 24215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E97")]
		[Address(RVA = "0x1431134", Offset = "0x1431134", VA = "0x7BBBC31134")]
		private void PlatformLoginDone(PlatformType platformType, string userId, string accessToken)
		{
		}

		// Token: 0x06005E98 RID: 24216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E98")]
		[Address(RVA = "0x14312F4", Offset = "0x14312F4", VA = "0x7BBBC312F4")]
		private void OnFacebookBindClick()
		{
		}

		// Token: 0x06005E99 RID: 24217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E99")]
		[Address(RVA = "0x14312FC", Offset = "0x14312FC", VA = "0x7BBBC312FC")]
		private void OnVKontakteBindClick()
		{
		}

		// Token: 0x06005E9A RID: 24218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E9A")]
		[Address(RVA = "0x1431304", Offset = "0x1431304", VA = "0x7BBBC31304")]
		private void OnHuaweiBindClick()
		{
		}

		// Token: 0x06005E9B RID: 24219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E9B")]
		[Address(RVA = "0x1431370", Offset = "0x1431370", VA = "0x7BBBC31370")]
		private void OnGoogleBindClick()
		{
		}

		// Token: 0x06005E9C RID: 24220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E9C")]
		[Address(RVA = "0x1431378", Offset = "0x1431378", VA = "0x7BBBC31378")]
		private void OnAppleBindClick()
		{
		}

		// Token: 0x06005E9D RID: 24221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E9D")]
		[Address(RVA = "0x1431380", Offset = "0x1431380", VA = "0x7BBBC31380")]
		private void OnTwitterBindClick()
		{
		}

		// Token: 0x06005E9E RID: 24222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E9E")]
		[Address(RVA = "0x1431388", Offset = "0x1431388", VA = "0x7BBBC31388")]
		private void OnCloseBtnClick()
		{
		}

		// Token: 0x06005E9F RID: 24223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E9F")]
		[Address(RVA = "0x143026C", Offset = "0x143026C", VA = "0x7BBBC3026C")]
		private void InitBindPlatformDict()
		{
		}

		// Token: 0x06005EA0 RID: 24224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EA0")]
		[Address(RVA = "0x1431390", Offset = "0x1431390", VA = "0x7BBBC31390")]
		private void CheckPlatformBtnState(PlatformType platformType)
		{
		}

		// Token: 0x06005EA1 RID: 24225 RVA: 0x0001B648 File Offset: 0x00019848
		[Token(Token = "0x6005EA1")]
		[Address(RVA = "0x1430B90", Offset = "0x1430B90", VA = "0x7BBBC30B90")]
		private bool CheckPlatformBindBtnCanShow(bool showOutOfMore, PlatformType platformType)
		{
			return default(bool);
		}

		// Token: 0x06005EA2 RID: 24226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EA2")]
		[Address(RVA = "0x14314D8", Offset = "0x14314D8", VA = "0x7BBBC314D8")]
		private void OnPlatformCombinedBtnClick()
		{
		}

		// Token: 0x06005EA3 RID: 24227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EA3")]
		[Address(RVA = "0x1431680", Offset = "0x1431680", VA = "0x7BBBC31680")]
		public UIBindAccountController()
		{
		}

		// Token: 0x06005EA4 RID: 24228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EA4")]
		[Address(RVA = "0x1431688", Offset = "0x1431688", VA = "0x7BBBC31688")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113FBE0", Offset = "0x113FBE0")]
		private void <BindGarena>b__13_0(BindSessionRsp rsp)
		{
		}

		// Token: 0x04007FC7 RID: 32711
		[Token(Token = "0x4007FC7")]
		[FieldOffset(Offset = "0x98")]
		private UIBindAccountView m_View;

		// Token: 0x04007FC8 RID: 32712
		[Token(Token = "0x4007FC8")]
		[FieldOffset(Offset = "0xA0")]
		private UIModelLogin m_ModelLogin;

		// Token: 0x04007FC9 RID: 32713
		[Token(Token = "0x4007FC9")]
		[FieldOffset(Offset = "0xA8")]
		private Dictionary<PlatformType, bool> m_PlatformNeedShowOutOfMore;

		// Token: 0x04007FCA RID: 32714
		[Token(Token = "0x4007FCA")]
		[FieldOffset(Offset = "0xB0")]
		private Dictionary<PlatformType, bool> m_PlatformSupportSignin;

		// Token: 0x0200155B RID: 5467
		[Token(Token = "0x200155B")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EE61C", Offset = "0x10EE61C")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06005EA6 RID: 24230 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005EA6")]
			[Address(RVA = "0x1431754", Offset = "0x1431754", VA = "0x7BBBC31754")]
			public <>c()
			{
			}

			// Token: 0x06005EA7 RID: 24231 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005EA7")]
			[Address(RVA = "0x143175C", Offset = "0x143175C", VA = "0x7BBBC3175C")]
			internal void <BindGarena>b__13_1(ErrorCode errCode)
			{
			}

			// Token: 0x04007FCB RID: 32715
			[Token(Token = "0x4007FCB")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIBindAccountController.<>c <>9;

			// Token: 0x04007FCC RID: 32716
			[Token(Token = "0x4007FCC")]
			[FieldOffset(Offset = "0x8")]
			public static SDKBind.GetBindSessionFaildCb <>9__13_1;
		}
	}
}
