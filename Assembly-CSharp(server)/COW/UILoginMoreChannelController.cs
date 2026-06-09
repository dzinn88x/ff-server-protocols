using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001A28 RID: 6696
	[Token(Token = "0x2001A28")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F7A0C", Offset = "0x10F7A0C")]
	public class UILoginMoreChannelController : UIPopupWindowController
	{
		// Token: 0x06008C69 RID: 35945 RVA: 0x00025770 File Offset: 0x00023970
		[Token(Token = "0x6008C69")]
		[Address(RVA = "0x19E74E8", Offset = "0x19E74E8", VA = "0x7BBC1E74E8")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008C6A RID: 35946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C6A")]
		[Address(RVA = "0x19E7538", Offset = "0x19E7538", VA = "0x7BBC1E7538", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008C6B RID: 35947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C6B")]
		[Address(RVA = "0x19E7724", Offset = "0x19E7724", VA = "0x7BBC1E7724", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06008C6C RID: 35948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C6C")]
		[Address(RVA = "0x19E42B8", Offset = "0x19E42B8", VA = "0x7BBC1E42B8")]
		public void Init(bool hasShowVK, bool hasShowFacebook, bool hasShowGoogle, bool hasShowTwitter)
		{
		}

		// Token: 0x06008C6D RID: 35949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C6D")]
		[Address(RVA = "0x19E772C", Offset = "0x19E772C", VA = "0x7BBC1E772C")]
		private void OnVKClick()
		{
		}

		// Token: 0x06008C6E RID: 35950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C6E")]
		[Address(RVA = "0x19E7760", Offset = "0x19E7760", VA = "0x7BBC1E7760")]
		private void OnGoogleClick()
		{
		}

		// Token: 0x06008C6F RID: 35951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C6F")]
		[Address(RVA = "0x19E7794", Offset = "0x19E7794", VA = "0x7BBC1E7794")]
		private void OnFacebookClick()
		{
		}

		// Token: 0x06008C70 RID: 35952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C70")]
		[Address(RVA = "0x19E77C8", Offset = "0x19E77C8", VA = "0x7BBC1E77C8")]
		private void OnTwitterClick()
		{
		}

		// Token: 0x06008C71 RID: 35953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C71")]
		[Address(RVA = "0x19E77FC", Offset = "0x19E77FC", VA = "0x7BBC1E77FC")]
		public UILoginMoreChannelController()
		{
		}

		// Token: 0x040098E8 RID: 39144
		[Token(Token = "0x40098E8")]
		[FieldOffset(Offset = "0x98")]
		private UILoginMoreChannelView m_View;

		// Token: 0x040098E9 RID: 39145
		[Token(Token = "0x40098E9")]
		[FieldOffset(Offset = "0xA0")]
		public Action ActionVKClick;

		// Token: 0x040098EA RID: 39146
		[Token(Token = "0x40098EA")]
		[FieldOffset(Offset = "0xA8")]
		public Action ActionGoogleClick;

		// Token: 0x040098EB RID: 39147
		[Token(Token = "0x40098EB")]
		[FieldOffset(Offset = "0xB0")]
		public Action ActionFacebookClick;

		// Token: 0x040098EC RID: 39148
		[Token(Token = "0x40098EC")]
		[FieldOffset(Offset = "0xB8")]
		public Action ActionTwitterClick;
	}
}
