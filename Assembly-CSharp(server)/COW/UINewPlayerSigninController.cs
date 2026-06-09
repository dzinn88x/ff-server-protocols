using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001AA2 RID: 6818
	[Token(Token = "0x2001AA2")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F878C", Offset = "0x10F878C")]
	public class UINewPlayerSigninController : UIBaseController, IUIModelDataChangeObserver
	{
		// Token: 0x06008FBE RID: 36798 RVA: 0x000264D8 File Offset: 0x000246D8
		[Token(Token = "0x6008FBE")]
		[Address(RVA = "0x1AFA2FC", Offset = "0x1AFA2FC", VA = "0x7BBC2FA2FC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008FBF RID: 36799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008FBF")]
		[Address(RVA = "0x1AFA34C", Offset = "0x1AFA34C", VA = "0x7BBC2FA34C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008FC0 RID: 36800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008FC0")]
		[Address(RVA = "0x1AFA898", Offset = "0x1AFA898", VA = "0x7BBC2FA898", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x06008FC1 RID: 36801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008FC1")]
		[Address(RVA = "0x1AFA9C0", Offset = "0x1AFA9C0", VA = "0x7BBC2FA9C0")]
		private void RefreshUI()
		{
		}

		// Token: 0x06008FC2 RID: 36802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008FC2")]
		[Address(RVA = "0x1AFA744", Offset = "0x1AFA744", VA = "0x7BBC2FA744")]
		private void SetCDNTexture()
		{
		}

		// Token: 0x06008FC3 RID: 36803 RVA: 0x000264F0 File Offset: 0x000246F0
		[Token(Token = "0x6008FC3")]
		[Address(RVA = "0x1AFB304", Offset = "0x1AFB304", VA = "0x7BBC2FB304", Slot = "29")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06008FC4 RID: 36804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008FC4")]
		[Address(RVA = "0x1AFB368", Offset = "0x1AFB368", VA = "0x7BBC2FB368", Slot = "28")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06008FC5 RID: 36805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008FC5")]
		[Address(RVA = "0x1AFB6D4", Offset = "0x1AFB6D4", VA = "0x7BBC2FB6D4")]
		public UINewPlayerSigninController()
		{
		}

		// Token: 0x06008FC6 RID: 36806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008FC6")]
		[Address(RVA = "0x1AFB744", Offset = "0x1AFB744", VA = "0x7BBC2FB744")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1144818", Offset = "0x1144818")]
		private void <OnUIInit>b__5_0()
		{
		}

		// Token: 0x04009BCD RID: 39885
		[Token(Token = "0x4009BCD")]
		[FieldOffset(Offset = "0x58")]
		private UINewPlayerSigninViewExt m_View;

		// Token: 0x04009BCE RID: 39886
		[Token(Token = "0x4009BCE")]
		[FieldOffset(Offset = "0x60")]
		private List<UINewPlayerSigninItemController> m_ItemControllerList;

		// Token: 0x04009BCF RID: 39887
		[Token(Token = "0x4009BCF")]
		[FieldOffset(Offset = "0x68")]
		private UINewPlayerSigninItemController m_SpecialItemController;

		// Token: 0x04009BD0 RID: 39888
		[Token(Token = "0x4009BD0")]
		[FieldOffset(Offset = "0x70")]
		private UICountDownController m_CountDownCtrl;

		// Token: 0x02001AA3 RID: 6819
		[Token(Token = "0x2001AA3")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F87C4", Offset = "0x10F87C4")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06008FC8 RID: 36808 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008FC8")]
			[Address(RVA = "0x1AFB804", Offset = "0x1AFB804", VA = "0x7BBC2FB804")]
			public <>c()
			{
			}

			// Token: 0x06008FC9 RID: 36809 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6008FC9")]
			[Address(RVA = "0x1AFB80C", Offset = "0x1AFB80C", VA = "0x7BBC2FB80C")]
			internal CommonRewardItemInfo <OnDataChanged>b__10_0(BaseItemInfo item)
			{
				return null;
			}

			// Token: 0x04009BD1 RID: 39889
			[Token(Token = "0x4009BD1")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UINewPlayerSigninController.<>c <>9;

			// Token: 0x04009BD2 RID: 39890
			[Token(Token = "0x4009BD2")]
			[FieldOffset(Offset = "0x8")]
			public static Converter<BaseItemInfo, CommonRewardItemInfo> <>9__10_0;
		}
	}
}
