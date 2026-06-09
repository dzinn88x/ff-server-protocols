using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200162E RID: 5678
	[Token(Token = "0x200162E")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EFD44", Offset = "0x10EFD44")]
	internal class UIHudPVETurnInfoController : UIBaseController, IUIModelDataChangeObserver
	{
		// Token: 0x0600662A RID: 26154 RVA: 0x0001D298 File Offset: 0x0001B498
		[Token(Token = "0x600662A")]
		[Address(RVA = "0x1D6AAA4", Offset = "0x1D6AAA4", VA = "0x7BBC56AAA4")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600662B RID: 26155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600662B")]
		[Address(RVA = "0x1D6AAF4", Offset = "0x1D6AAF4", VA = "0x7BBC56AAF4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600662C RID: 26156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600662C")]
		[Address(RVA = "0x1D6AE04", Offset = "0x1D6AE04", VA = "0x7BBC56AE04", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x0600662D RID: 26157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600662D")]
		[Address(RVA = "0x1D6AF90", Offset = "0x1D6AF90", VA = "0x7BBC56AF90")]
		private void PlayerMidAnimation(byte turn)
		{
		}

		// Token: 0x0600662E RID: 26158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600662E")]
		[Address(RVA = "0x1D6B1B4", Offset = "0x1D6B1B4", VA = "0x7BBC56B1B4")]
		private void OnNewRoundStart(object[] data)
		{
		}

		// Token: 0x0600662F RID: 26159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600662F")]
		[Address(RVA = "0x1D6B240", Offset = "0x1D6B240", VA = "0x7BBC56B240", Slot = "28")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06006630 RID: 26160 RVA: 0x0001D2B0 File Offset: 0x0001B4B0
		[Token(Token = "0x6006630")]
		[Address(RVA = "0x1D6B4A0", Offset = "0x1D6B4A0", VA = "0x7BBC56B4A0", Slot = "29")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06006631 RID: 26161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006631")]
		[Address(RVA = "0x1D6B4E4", Offset = "0x1D6B4E4", VA = "0x7BBC56B4E4")]
		public UIHudPVETurnInfoController()
		{
		}

		// Token: 0x06006632 RID: 26162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006632")]
		[Address(RVA = "0x1D6B4EC", Offset = "0x1D6B4EC", VA = "0x7BBC56B4EC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1140758", Offset = "0x1140758")]
		private void <PlayerMidAnimation>b__5_0()
		{
		}

		// Token: 0x0400840D RID: 33805
		[Token(Token = "0x400840D")]
		[FieldOffset(Offset = "0x58")]
		private UIHudPVETurnInfoView m_View;

		// Token: 0x0400840E RID: 33806
		[Token(Token = "0x400840E")]
		[FieldOffset(Offset = "0x60")]
		private uint m_delcayCall;
	}
}
