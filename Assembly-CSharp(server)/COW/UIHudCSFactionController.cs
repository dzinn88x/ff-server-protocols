using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020014B7 RID: 5303
	[Token(Token = "0x20014B7")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10ED64C", Offset = "0x10ED64C")]
	internal class UIHudCSFactionController : UIBaseController
	{
		// Token: 0x06005A04 RID: 23044 RVA: 0x0001A820 File Offset: 0x00018A20
		[Token(Token = "0x6005A04")]
		[Address(RVA = "0x19B96E0", Offset = "0x19B96E0", VA = "0x7BBC1B96E0")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005A05 RID: 23045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A05")]
		[Address(RVA = "0x19B9730", Offset = "0x19B9730", VA = "0x7BBC1B9730", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005A06 RID: 23046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A06")]
		[Address(RVA = "0x19B9958", Offset = "0x19B9958", VA = "0x7BBC1B9958", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06005A07 RID: 23047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A07")]
		[Address(RVA = "0x19B9B80", Offset = "0x19B9B80", VA = "0x7BBC1B9B80")]
		private void SetUIData()
		{
		}

		// Token: 0x06005A08 RID: 23048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A08")]
		[Address(RVA = "0x19BA0A0", Offset = "0x19BA0A0", VA = "0x7BBC1BA0A0")]
		private void SetODFaction(int localODFactionId)
		{
		}

		// Token: 0x06005A09 RID: 23049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A09")]
		[Address(RVA = "0x19BA25C", Offset = "0x19BA25C", VA = "0x7BBC1BA25C")]
		private void OnODFactionChanged(params object[] data)
		{
		}

		// Token: 0x06005A0A RID: 23050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A0A")]
		[Address(RVA = "0x19BA324", Offset = "0x19BA324", VA = "0x7BBC1BA324")]
		private void OnLocalPlayerJoin(params object[] data)
		{
		}

		// Token: 0x06005A0B RID: 23051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A0B")]
		[Address(RVA = "0x19BA4FC", Offset = "0x19BA4FC", VA = "0x7BBC1BA4FC")]
		private void OnLoadingMaskClosed(params object[] data)
		{
		}

		// Token: 0x06005A0C RID: 23052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A0C")]
		[Address(RVA = "0x19BA3C8", Offset = "0x19BA3C8", VA = "0x7BBC1BA3C8")]
		private void CheckStartDelayShow()
		{
		}

		// Token: 0x06005A0D RID: 23053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A0D")]
		[Address(RVA = "0x19BA508", Offset = "0x19BA508", VA = "0x7BBC1BA508")]
		private void OnPhaseChanged(params object[] data)
		{
		}

		// Token: 0x06005A0E RID: 23054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A0E")]
		[Address(RVA = "0x19BA5FC", Offset = "0x19BA5FC", VA = "0x7BBC1BA5FC")]
		private void OnODFactionSwitchDone(params object[] data)
		{
		}

		// Token: 0x06005A0F RID: 23055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A0F")]
		[Address(RVA = "0x19BA708", Offset = "0x19BA708", VA = "0x7BBC1BA708")]
		private void ShowAndPlaySound()
		{
		}

		// Token: 0x06005A10 RID: 23056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A10")]
		[Address(RVA = "0x19BA7BC", Offset = "0x19BA7BC", VA = "0x7BBC1BA7BC")]
		public UIHudCSFactionController()
		{
		}

		// Token: 0x04007D39 RID: 32057
		[Token(Token = "0x4007D39")]
		[FieldOffset(Offset = "0x58")]
		private UIHudCSFactionView m_View;

		// Token: 0x04007D3A RID: 32058
		[Token(Token = "0x4007D3A")]
		[FieldOffset(Offset = "0x60")]
		private uint m_DelayCallId;

		// Token: 0x04007D3B RID: 32059
		[Token(Token = "0x4007D3B")]
		[FieldOffset(Offset = "0x64")]
		private uint m_DelayCallIdShow;

		// Token: 0x04007D3C RID: 32060
		[Token(Token = "0x4007D3C")]
		[FieldOffset(Offset = "0x68")]
		private bool mLocalPlayerJoined;

		// Token: 0x04007D3D RID: 32061
		[Token(Token = "0x4007D3D")]
		[FieldOffset(Offset = "0x69")]
		private bool mLoadingMaskClosed;
	}
}
