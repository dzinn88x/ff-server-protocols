using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200197B RID: 6523
	[Token(Token = "0x200197B")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F65D4", Offset = "0x10F65D4")]
	internal class UIHudTimerController : UIBaseController, IUIModelDataChangeObserver
	{
		// Token: 0x060084EF RID: 34031 RVA: 0x00024090 File Offset: 0x00022290
		[Token(Token = "0x60084EF")]
		[Address(RVA = "0x15E5E3C", Offset = "0x15E5E3C", VA = "0x7BBBDE5E3C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060084F0 RID: 34032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60084F0")]
		[Address(RVA = "0x15E5E8C", Offset = "0x15E5E8C", VA = "0x7BBBDE5E8C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060084F1 RID: 34033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60084F1")]
		[Address(RVA = "0x15E5FA4", Offset = "0x15E5FA4", VA = "0x7BBBDE5FA4", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060084F2 RID: 34034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60084F2")]
		[Address(RVA = "0x15E5FE4", Offset = "0x15E5FE4", VA = "0x7BBBDE5FE4", Slot = "28")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x060084F3 RID: 34035 RVA: 0x000240A8 File Offset: 0x000222A8
		[Token(Token = "0x60084F3")]
		[Address(RVA = "0x15E628C", Offset = "0x15E628C", VA = "0x7BBBDE628C", Slot = "29")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x060084F4 RID: 34036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60084F4")]
		[Address(RVA = "0x15E62D0", Offset = "0x15E62D0", VA = "0x7BBBDE62D0")]
		public UIHudTimerController()
		{
		}

		// Token: 0x040094D9 RID: 38105
		[Token(Token = "0x40094D9")]
		[FieldOffset(Offset = "0x58")]
		private UIHudTimerViewExt m_View;

		// Token: 0x040094DA RID: 38106
		[Token(Token = "0x40094DA")]
		[FieldOffset(Offset = "0x60")]
		private UIModelMatch m_MatchModel;
	}
}
