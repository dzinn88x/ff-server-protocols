using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020017D3 RID: 6099
	[Token(Token = "0x20017D3")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F2D8C", Offset = "0x10F2D8C")]
	public class UIFriendReunionInviterController : UIBaseController
	{
		// Token: 0x06007582 RID: 30082 RVA: 0x00020A00 File Offset: 0x0001EC00
		[Token(Token = "0x6007582")]
		[Address(RVA = "0x159DA44", Offset = "0x159DA44", VA = "0x7BBBD9DA44")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007583 RID: 30083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007583")]
		[Address(RVA = "0x159DA94", Offset = "0x159DA94", VA = "0x7BBBD9DA94", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007584 RID: 30084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007584")]
		[Address(RVA = "0x159DBB4", Offset = "0x159DBB4", VA = "0x7BBBD9DBB4")]
		public void SetWidth(int width)
		{
		}

		// Token: 0x06007585 RID: 30085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007585")]
		[Address(RVA = "0x159DBFC", Offset = "0x159DBFC", VA = "0x7BBBD9DBFC")]
		public void SetData(ActivityGroupDesc activityGroupDesc)
		{
		}

		// Token: 0x06007586 RID: 30086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007586")]
		[Address(RVA = "0x159DC00", Offset = "0x159DC00", VA = "0x7BBBD9DC00")]
		public void SetProgress(int current, int max)
		{
		}

		// Token: 0x06007587 RID: 30087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007587")]
		[Address(RVA = "0x159DD24", Offset = "0x159DD24", VA = "0x7BBBD9DD24")]
		public void UpdateData(ulong endsAt)
		{
		}

		// Token: 0x06007588 RID: 30088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007588")]
		[Address(RVA = "0x159DDE8", Offset = "0x159DDE8", VA = "0x7BBBD9DDE8")]
		public UIFriendReunionInviterController()
		{
		}

		// Token: 0x04008CE1 RID: 36065
		[Token(Token = "0x4008CE1")]
		[FieldOffset(Offset = "0x58")]
		private UIFriendReunionInviterView m_View;

		// Token: 0x04008CE2 RID: 36066
		[Token(Token = "0x4008CE2")]
		[FieldOffset(Offset = "0x60")]
		private UICountDownController m_CDControler;
	}
}
