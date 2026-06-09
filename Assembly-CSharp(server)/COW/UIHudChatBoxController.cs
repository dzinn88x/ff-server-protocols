using System;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001680 RID: 5760
	[Token(Token = "0x2001680")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F03D4", Offset = "0x10F03D4")]
	public class UIHudChatBoxController : UIHudNameBaseController
	{
		// Token: 0x06006890 RID: 26768 RVA: 0x0001DA48 File Offset: 0x0001BC48
		[Token(Token = "0x6006890")]
		[Address(RVA = "0x1A8F848", Offset = "0x1A8F848", VA = "0x7BBC28F848")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006891 RID: 26769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006891")]
		[Address(RVA = "0x1A8F898", Offset = "0x1A8F898", VA = "0x7BBC28F898", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006892 RID: 26770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006892")]
		[Address(RVA = "0x1A8F8FC", Offset = "0x1A8F8FC", VA = "0x7BBC28F8FC")]
		public void BindPlayer({QAb\u0082~u player_id, string msg)
		{
		}

		// Token: 0x06006893 RID: 26771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006893")]
		[Address(RVA = "0x1A8FA94", Offset = "0x1A8FA94", VA = "0x7BBC28FA94")]
		public void UnBindPlayer()
		{
		}

		// Token: 0x06006894 RID: 26772 RVA: 0x0001DA60 File Offset: 0x0001BC60
		[Token(Token = "0x6006894")]
		[Address(RVA = "0x1A8FBB0", Offset = "0x1A8FBB0", VA = "0x7BBC28FBB0", Slot = "31")]
		protected override bool NeedUpdatePosition()
		{
			return default(bool);
		}

		// Token: 0x06006895 RID: 26773 RVA: 0x0001DA78 File Offset: 0x0001BC78
		[Token(Token = "0x6006895")]
		[Address(RVA = "0x1A8FD28", Offset = "0x1A8FD28", VA = "0x7BBC28FD28", Slot = "28")]
		protected override Vector3 TargetPosition()
		{
			return default(Vector3);
		}

		// Token: 0x06006896 RID: 26774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006896")]
		[Address(RVA = "0x1A8FD60", Offset = "0x1A8FD60", VA = "0x7BBC28FD60", Slot = "19")]
		protected override void OnVisibilityChanged()
		{
		}

		// Token: 0x06006897 RID: 26775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006897")]
		[Address(RVA = "0x1A8FD68", Offset = "0x1A8FD68", VA = "0x7BBC28FD68")]
		public UIHudChatBoxController()
		{
		}

		// Token: 0x06006898 RID: 26776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006898")]
		[Address(RVA = "0x1A8FD70", Offset = "0x1A8FD70", VA = "0x7BBC28FD70")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1140B2C", Offset = "0x1140B2C")]
		private void <BindPlayer>b__6_0()
		{
		}

		// Token: 0x0400854D RID: 34125
		[Token(Token = "0x400854D")]
		[FieldOffset(Offset = "0xA8")]
		private UIHudChatboxView m_View;

		// Token: 0x0400854E RID: 34126
		[Token(Token = "0x400854E")]
		[FieldOffset(Offset = "0xB0")]
		private {QAb\u0082~u m_TargetPlayerID;

		// Token: 0x0400854F RID: 34127
		[Token(Token = "0x400854F")]
		[FieldOffset(Offset = "0xC8")]
		private Player m_Player;

		// Token: 0x04008550 RID: 34128
		[Token(Token = "0x4008550")]
		[FieldOffset(Offset = "0xD0")]
		private uint m_DelayCallID;
	}
}
