using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020020AC RID: 8364
	[Token(Token = "0x20020AC")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FDD8C", Offset = "0x10FDD8C")]
	internal class UIInvitationTipsBoxController : UIBaseController
	{
		// Token: 0x0600BC33 RID: 48179 RVA: 0x00035328 File Offset: 0x00033528
		[Token(Token = "0x600BC33")]
		[Address(RVA = "0x192157C", Offset = "0x192157C", VA = "0x7BBC12157C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600BC34 RID: 48180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC34")]
		[Address(RVA = "0x19215CC", Offset = "0x19215CC", VA = "0x7BBC1215CC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600BC35 RID: 48181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC35")]
		[Address(RVA = "0x1921800", Offset = "0x1921800", VA = "0x7BBC121800", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x0600BC36 RID: 48182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC36")]
		[Address(RVA = "0x19219C8", Offset = "0x19219C8", VA = "0x7BBC1219C8")]
		private void HideInvitationTipsBox(params object[] args)
		{
		}

		// Token: 0x0600BC37 RID: 48183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC37")]
		[Address(RVA = "0x1921A6C", Offset = "0x1921A6C", VA = "0x7BBC121A6C")]
		public void SetUIData()
		{
		}

		// Token: 0x0600BC38 RID: 48184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC38")]
		[Address(RVA = "0x1922018", Offset = "0x1922018", VA = "0x7BBC122018")]
		private void Expired(params object[] args)
		{
		}

		// Token: 0x0600BC39 RID: 48185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC39")]
		[Address(RVA = "0x1921EB8", Offset = "0x1921EB8", VA = "0x7BBC121EB8")]
		private void ResetContentDepth()
		{
		}

		// Token: 0x0600BC3A RID: 48186 RVA: 0x00035340 File Offset: 0x00033540
		[Token(Token = "0x600BC3A")]
		[Address(RVA = "0x192248C", Offset = "0x192248C", VA = "0x7BBC12248C")]
		private bool CheckData(object[] args)
		{
			return default(bool);
		}

		// Token: 0x0600BC3B RID: 48187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC3B")]
		[Address(RVA = "0x1921C84", Offset = "0x1921C84", VA = "0x7BBC121C84")]
		public void GetUIData(out object[] data, out ulong time, out ulong id)
		{
		}

		// Token: 0x0600BC3C RID: 48188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC3C")]
		[Address(RVA = "0x19222C8", Offset = "0x19222C8", VA = "0x7BBC1222C8")]
		public void PeekUIData(out object[] data)
		{
		}

		// Token: 0x0600BC3D RID: 48189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC3D")]
		[Address(RVA = "0x19221FC", Offset = "0x19221FC", VA = "0x7BBC1221FC")]
		private void OnExpired(params object[] args)
		{
		}

		// Token: 0x0600BC3E RID: 48190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC3E")]
		[Address(RVA = "0x1921E48", Offset = "0x1921E48", VA = "0x7BBC121E48")]
		private void AddContent(UIInvitationTipsBoxContentController content)
		{
		}

		// Token: 0x0600BC3F RID: 48191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC3F")]
		[Address(RVA = "0x1922198", Offset = "0x1922198", VA = "0x7BBC122198")]
		private void RemoveContent()
		{
		}

		// Token: 0x0600BC40 RID: 48192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC40")]
		[Address(RVA = "0x1922A3C", Offset = "0x1922A3C", VA = "0x7BBC122A3C")]
		public void GroupInviteBlock(params object[] arg)
		{
		}

		// Token: 0x0600BC41 RID: 48193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC41")]
		[Address(RVA = "0x1922BA0", Offset = "0x1922BA0", VA = "0x7BBC122BA0")]
		public void GroupJoinBlock(params object[] arg)
		{
		}

		// Token: 0x0600BC42 RID: 48194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC42")]
		[Address(RVA = "0x1922D04", Offset = "0x1922D04", VA = "0x7BBC122D04")]
		public UIInvitationTipsBoxController()
		{
		}

		// Token: 0x0400BCD7 RID: 48343
		[Token(Token = "0x400BCD7")]
		[FieldOffset(Offset = "0x58")]
		private UIInvitationTipsBoxView m_View;

		// Token: 0x0400BCD8 RID: 48344
		[Token(Token = "0x400BCD8")]
		[FieldOffset(Offset = "0x60")]
		private UIModelInvitation m_ModelInvitation;

		// Token: 0x0400BCD9 RID: 48345
		[Token(Token = "0x400BCD9")]
		[FieldOffset(Offset = "0x68")]
		private List<UIInvitationTipsBoxContentController> ContentList;
	}
}
