using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001950 RID: 6480
	[Token(Token = "0x2001950")]
	public class UIHudReservationItemController : UIBaseController
	{
		// Token: 0x06008380 RID: 33664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008380")]
		[Address(RVA = "0x17F5AD0", Offset = "0x17F5AD0", VA = "0x7BBBFF5AD0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008381 RID: 33665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008381")]
		[Address(RVA = "0x17F5C9C", Offset = "0x17F5C9C", VA = "0x7BBBFF5C9C")]
		private void InitView()
		{
		}

		// Token: 0x06008382 RID: 33666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008382")]
		[Address(RVA = "0x17F5D44", Offset = "0x17F5D44", VA = "0x7BBBFF5D44")]
		public void SetData(ulong id, UIModelTeamReserve.ReserveReplyStatus status)
		{
		}

		// Token: 0x06008383 RID: 33667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008383")]
		[Address(RVA = "0x17F6198", Offset = "0x17F6198", VA = "0x7BBBFF6198")]
		private void OnAgreeBtnClick()
		{
		}

		// Token: 0x06008384 RID: 33668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008384")]
		[Address(RVA = "0x17F61E4", Offset = "0x17F61E4", VA = "0x7BBBFF61E4")]
		private void OnRejectBtnClick()
		{
		}

		// Token: 0x06008385 RID: 33669 RVA: 0x00023B50 File Offset: 0x00021D50
		[Token(Token = "0x6008385")]
		[Address(RVA = "0x17F6230", Offset = "0x17F6230", VA = "0x7BBBFF6230")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008386 RID: 33670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008386")]
		[Address(RVA = "0x17F6280", Offset = "0x17F6280", VA = "0x7BBBFF6280")]
		public UIHudReservationItemController()
		{
		}

		// Token: 0x0400944A RID: 37962
		[Token(Token = "0x400944A")]
		[FieldOffset(Offset = "0x58")]
		private UIHudReservationItemView m_View;

		// Token: 0x0400944B RID: 37963
		[Token(Token = "0x400944B")]
		[FieldOffset(Offset = "0x60")]
		private UIModelTeamReserve m_Model;

		// Token: 0x0400944C RID: 37964
		[Token(Token = "0x400944C")]
		[FieldOffset(Offset = "0x68")]
		private FriendAccountInfo m_Friend;
	}
}
