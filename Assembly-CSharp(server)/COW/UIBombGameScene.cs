using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02002066 RID: 8294
	[Token(Token = "0x2002066")]
	internal class UIBombGameScene : UIInGameScene
	{
		// Token: 0x0600B8CA RID: 47306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B8CA")]
		[Address(RVA = "0x1431E24", Offset = "0x1431E24", VA = "0x7BBBC31E24", Slot = "12")]
		protected override void OpenCommonHud()
		{
		}

		// Token: 0x0600B8CB RID: 47307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B8CB")]
		[Address(RVA = "0x1432238", Offset = "0x1432238", VA = "0x7BBBC32238", Slot = "10")]
		public override void RegisterGameEventHandler()
		{
		}

		// Token: 0x0600B8CC RID: 47308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B8CC")]
		[Address(RVA = "0x14324FC", Offset = "0x14324FC", VA = "0x7BBBC324FC", Slot = "4")]
		public override void Destory()
		{
		}

		// Token: 0x0600B8CD RID: 47309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B8CD")]
		[Address(RVA = "0x143276C", Offset = "0x143276C", VA = "0x7BBBC3276C")]
		private void OnBombNewPhaseStarted(params object[] param)
		{
		}

		// Token: 0x0600B8CE RID: 47310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B8CE")]
		[Address(RVA = "0x14329F8", Offset = "0x14329F8", VA = "0x7BBBC329F8")]
		public void OnPlayerGetBomb(params object[] data)
		{
		}

		// Token: 0x0600B8CF RID: 47311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B8CF")]
		[Address(RVA = "0x1432AA8", Offset = "0x1432AA8", VA = "0x7BBBC32AA8")]
		public void OnBombSettled(params object[] data)
		{
		}

		// Token: 0x0600B8D0 RID: 47312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B8D0")]
		[Address(RVA = "0x1432B58", Offset = "0x1432B58", VA = "0x7BBBC32B58")]
		public void OnBombZoneInfoChanged(params object[] data)
		{
		}

		// Token: 0x0600B8D1 RID: 47313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B8D1")]
		[Address(RVA = "0x1432E38", Offset = "0x1432E38", VA = "0x7BBBC32E38", Slot = "14")]
		protected override Type GetMatchResultType()
		{
			return null;
		}

		// Token: 0x0600B8D2 RID: 47314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B8D2")]
		[Address(RVA = "0x1432EA8", Offset = "0x1432EA8", VA = "0x7BBBC32EA8")]
		public UIBombGameScene()
		{
		}

		// Token: 0x0400BA81 RID: 47745
		[Token(Token = "0x400BA81")]
		[FieldOffset(Offset = "0x3D0")]
		protected UIHudBombMatchInfoController m_BombMatchInfoInfoCtrl;

		// Token: 0x0400BA82 RID: 47746
		[Token(Token = "0x400BA82")]
		[FieldOffset(Offset = "0x3D8")]
		public Dictionary<uint, UIHudBombZoneMarkController> m_BombZoneMarkList;

		// Token: 0x0400BA83 RID: 47747
		[Token(Token = "0x400BA83")]
		[FieldOffset(Offset = "0x3E0")]
		private uint m_HideCSShopDelayCallID;
	}
}
