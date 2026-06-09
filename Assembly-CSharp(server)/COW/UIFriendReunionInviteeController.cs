using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x020017D1 RID: 6097
	[Token(Token = "0x20017D1")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F2D44", Offset = "0x10F2D44")]
	public class UIFriendReunionInviteeController : UIBaseController
	{
		// Token: 0x06007573 RID: 30067 RVA: 0x000209D0 File Offset: 0x0001EBD0
		[Token(Token = "0x6007573")]
		[Address(RVA = "0x159C6F4", Offset = "0x159C6F4", VA = "0x7BBBD9C6F4")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007574 RID: 30068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007574")]
		[Address(RVA = "0x159C744", Offset = "0x159C744", VA = "0x7BBBD9C744", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007575 RID: 30069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007575")]
		[Address(RVA = "0x159CB48", Offset = "0x159CB48", VA = "0x7BBBD9CB48", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x06007576 RID: 30070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007576")]
		[Address(RVA = "0x159CC14", Offset = "0x159CC14", VA = "0x7BBBD9CC14")]
		public void SetWidth(int width)
		{
		}

		// Token: 0x06007577 RID: 30071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007577")]
		[Address(RVA = "0x159CC98", Offset = "0x159CC98", VA = "0x7BBBD9CC98")]
		public void SetData(ActivityGroupDesc activityGroupDesc, string inviterUID, bool gained = false)
		{
		}

		// Token: 0x06007578 RID: 30072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007578")]
		[Address(RVA = "0x159CE6C", Offset = "0x159CE6C", VA = "0x7BBBD9CE6C")]
		private void OnInvitationInputGetFocus()
		{
		}

		// Token: 0x06007579 RID: 30073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007579")]
		[Address(RVA = "0x159CDD0", Offset = "0x159CDD0", VA = "0x7BBBD9CDD0")]
		private void OnInvitationInputLostFocus()
		{
		}

		// Token: 0x0600757A RID: 30074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600757A")]
		[Address(RVA = "0x159C9F4", Offset = "0x159C9F4", VA = "0x7BBBD9C9F4")]
		private void OnInvitationInputChanged()
		{
		}

		// Token: 0x0600757B RID: 30075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600757B")]
		[Address(RVA = "0x159CEC8", Offset = "0x159CEC8", VA = "0x7BBBD9CEC8")]
		private void OnClaimButtonClick()
		{
		}

		// Token: 0x0600757C RID: 30076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600757C")]
		[Address(RVA = "0x159D2EC", Offset = "0x159D2EC", VA = "0x7BBBD9D2EC")]
		private void OnRewriteID(params object[] data)
		{
		}

		// Token: 0x0600757D RID: 30077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600757D")]
		[Address(RVA = "0x159D3BC", Offset = "0x159D3BC", VA = "0x7BBBD9D3BC")]
		public UIFriendReunionInviteeController()
		{
		}

		// Token: 0x04008CDB RID: 36059
		[Token(Token = "0x4008CDB")]
		[FieldOffset(Offset = "0x58")]
		private UIFriendReunionInviteeView m_View;

		// Token: 0x04008CDC RID: 36060
		[Token(Token = "0x4008CDC")]
		[FieldOffset(Offset = "0x60")]
		private ActivityGroupDesc m_Data;

		// Token: 0x04008CDD RID: 36061
		[Token(Token = "0x4008CDD")]
		[FieldOffset(Offset = "0x68")]
		private UIWidget m_ButtonWidget;

		// Token: 0x020017D2 RID: 6098
		[Token(Token = "0x20017D2")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F2D7C", Offset = "0x10F2D7C")]
		private sealed class <>c__DisplayClass11_0
		{
			// Token: 0x0600757E RID: 30078 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600757E")]
			[Address(RVA = "0x159D2E4", Offset = "0x159D2E4", VA = "0x7BBBD9D2E4")]
			public <>c__DisplayClass11_0()
			{
			}

			// Token: 0x0600757F RID: 30079 RVA: 0x000209E8 File Offset: 0x0001EBE8
			[Token(Token = "0x600757F")]
			[Address(RVA = "0x159D3C4", Offset = "0x159D3C4", VA = "0x7BBBD9D3C4")]
			internal bool <OnClaimButtonClick>b__0(FriendAccountInfo x)
			{
				return default(bool);
			}

			// Token: 0x06007580 RID: 30080 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007580")]
			[Address(RVA = "0x159D3FC", Offset = "0x159D3FC", VA = "0x7BBBD9D3FC")]
			internal void <OnClaimButtonClick>b__1(AccountInfoBasic basic)
			{
			}

			// Token: 0x06007581 RID: 30081 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007581")]
			[Address(RVA = "0x159D700", Offset = "0x159D700", VA = "0x7BBBD9D700")]
			internal void <OnClaimButtonClick>b__2()
			{
			}

			// Token: 0x04008CDE RID: 36062
			[Token(Token = "0x4008CDE")]
			[FieldOffset(Offset = "0x10")]
			public ulong inviter;

			// Token: 0x04008CDF RID: 36063
			[Token(Token = "0x4008CDF")]
			[FieldOffset(Offset = "0x18")]
			public UIFriendReunionInviteeController <>4__this;

			// Token: 0x04008CE0 RID: 36064
			[Token(Token = "0x4008CE0")]
			[FieldOffset(Offset = "0x20")]
			public Action <>9__2;
		}
	}
}
