using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200209D RID: 8349
	[Token(Token = "0x200209D")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FDB94", Offset = "0x10FDB94")]
	internal class UIHudBombDropPosMarkController : UIHudNameBaseController
	{
		// Token: 0x0600BBBB RID: 48059 RVA: 0x000351A8 File Offset: 0x000333A8
		[Token(Token = "0x600BBBB")]
		[Address(RVA = "0x1897F48", Offset = "0x1897F48", VA = "0x7BBC097F48")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600BBBC RID: 48060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BBBC")]
		[Address(RVA = "0x1897F98", Offset = "0x1897F98", VA = "0x7BBC097F98", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600BBBD RID: 48061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BBBD")]
		[Address(RVA = "0x18981BC", Offset = "0x18981BC", VA = "0x7BBC0981BC", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x0600BBBE RID: 48062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BBBE")]
		[Address(RVA = "0x1898330", Offset = "0x1898330", VA = "0x7BBC098330")]
		private void OnBombPickupDrop(params object[] data)
		{
		}

		// Token: 0x0600BBBF RID: 48063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BBBF")]
		[Address(RVA = "0x1898560", Offset = "0x1898560", VA = "0x7BBC098560")]
		private void OnBombPickupGet(params object[] data)
		{
		}

		// Token: 0x0600BBC0 RID: 48064 RVA: 0x000351C0 File Offset: 0x000333C0
		[Token(Token = "0x600BBC0")]
		[Address(RVA = "0x1898570", Offset = "0x1898570", VA = "0x7BBC098570", Slot = "28")]
		protected override Vector3 TargetPosition()
		{
			return default(Vector3);
		}

		// Token: 0x0600BBC1 RID: 48065 RVA: 0x000351D8 File Offset: 0x000333D8
		[Token(Token = "0x600BBC1")]
		[Address(RVA = "0x1898618", Offset = "0x1898618", VA = "0x7BBC098618", Slot = "30")]
		protected override bool NeedKeepInScreen()
		{
			return default(bool);
		}

		// Token: 0x0600BBC2 RID: 48066 RVA: 0x000351F0 File Offset: 0x000333F0
		[Token(Token = "0x600BBC2")]
		[Address(RVA = "0x1898620", Offset = "0x1898620", VA = "0x7BBC098620", Slot = "37")]
		protected override Vector2 GetWidgetBound()
		{
			return default(Vector2);
		}

		// Token: 0x0600BBC3 RID: 48067 RVA: 0x00035208 File Offset: 0x00033408
		[Token(Token = "0x600BBC3")]
		[Address(RVA = "0x1898740", Offset = "0x1898740", VA = "0x7BBC098740", Slot = "32")]
		protected override bool NeedShowDistance()
		{
			return default(bool);
		}

		// Token: 0x0600BBC4 RID: 48068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BBC4")]
		[Address(RVA = "0x1898748", Offset = "0x1898748", VA = "0x7BBC098748")]
		private void OnODFactionChanged(params object[] data)
		{
		}

		// Token: 0x0600BBC5 RID: 48069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BBC5")]
		[Address(RVA = "0x18987F8", Offset = "0x18987F8", VA = "0x7BBC0987F8")]
		public UIHudBombDropPosMarkController()
		{
		}

		// Token: 0x0400BC8C RID: 48268
		[Token(Token = "0x400BC8C")]
		[FieldOffset(Offset = "0xA8")]
		private UIHudBombDropPosMarkView m_View;

		// Token: 0x0400BC8D RID: 48269
		[Token(Token = "0x400BC8D")]
		[FieldOffset(Offset = "0xB0")]
		private Vector3 m_BombPos;
	}
}
