using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001ABE RID: 6846
	[Token(Token = "0x2001ABE")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F89E4", Offset = "0x10F89E4")]
	public class UIPaymentController : UINavigationController, IUIModelDataChangeObserver
	{
		// Token: 0x170009F4 RID: 2548
		// (get) Token: 0x06009076 RID: 36982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009F4")]
		private static UIPaymentController.Tab[] TabOrder
		{
			[Token(Token = "0x6009076")]
			[Address(RVA = "0x16FBBD8", Offset = "0x16FBBD8", VA = "0x7BBBEFBBD8")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009F5 RID: 2549
		// (get) Token: 0x06009077 RID: 36983 RVA: 0x000267D8 File Offset: 0x000249D8
		[Token(Token = "0x170009F5")]
		public static UIPaymentController.Tab DefaultTab
		{
			[Token(Token = "0x6009077")]
			[Address(RVA = "0x16FBC40", Offset = "0x16FBC40", VA = "0x7BBBEFBC40")]
			get
			{
				return UIPaymentController.Tab.None;
			}
		}

		// Token: 0x170009F6 RID: 2550
		// (get) Token: 0x06009078 RID: 36984 RVA: 0x000267F0 File Offset: 0x000249F0
		[Token(Token = "0x170009F6")]
		public static bool CanHandleDebt
		{
			[Token(Token = "0x6009078")]
			[Address(RVA = "0x16FBDD8", Offset = "0x16FBDD8", VA = "0x7BBBEFBDD8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06009079 RID: 36985 RVA: 0x00026808 File Offset: 0x00024A08
		[Token(Token = "0x6009079")]
		[Address(RVA = "0x16FBE4C", Offset = "0x16FBE4C", VA = "0x7BBBEFBE4C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600907A RID: 36986 RVA: 0x00026820 File Offset: 0x00024A20
		[Token(Token = "0x600907A")]
		[Address(RVA = "0x16FBE9C", Offset = "0x16FBE9C", VA = "0x7BBBEFBE9C", Slot = "33")]
		public override EFrontendUIType GetBackgroundImageType()
		{
			return EFrontendUIType.Lobby;
		}

		// Token: 0x0600907B RID: 36987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600907B")]
		[Address(RVA = "0x16FBEA4", Offset = "0x16FBEA4", VA = "0x7BBBEFBEA4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600907C RID: 36988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600907C")]
		[Address(RVA = "0x16FC00C", Offset = "0x16FC00C", VA = "0x7BBBEFC00C")]
		private void RefreshAll()
		{
		}

		// Token: 0x0600907D RID: 36989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600907D")]
		[Address(RVA = "0x16FCCFC", Offset = "0x16FCCFC", VA = "0x7BBBEFCCFC", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x0600907E RID: 36990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600907E")]
		[Address(RVA = "0x16FD460", Offset = "0x16FD460", VA = "0x7BBBEFD460")]
		private void OnTabItemGotoTab(params object[] parameters)
		{
		}

		// Token: 0x0600907F RID: 36991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600907F")]
		[Address(RVA = "0x16FD614", Offset = "0x16FD614", VA = "0x7BBBEFD614", Slot = "28")]
		public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
		{
		}

		// Token: 0x06009080 RID: 36992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009080")]
		[Address(RVA = "0x16FDA58", Offset = "0x16FDA58", VA = "0x7BBBEFDA58", Slot = "19")]
		protected override void OnVisibilityChanged()
		{
		}

		// Token: 0x06009081 RID: 36993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009081")]
		[Address(RVA = "0x16FC4A4", Offset = "0x16FC4A4", VA = "0x7BBBEFC4A4")]
		private void Goto(UIPaymentController.Tab tab, [Optional] UIPaymentController.PaymentGotoParams paymentGotoParams)
		{
		}

		// Token: 0x06009082 RID: 36994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009082")]
		[Address(RVA = "0x16FDAC4", Offset = "0x16FDAC4", VA = "0x7BBBEFDAC4")]
		private UIPaymentController.PaymentTabContentController Open(UIPaymentController.Tab tab)
		{
			return null;
		}

		// Token: 0x06009083 RID: 36995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009083")]
		[Address(RVA = "0x16FCBCC", Offset = "0x16FCBCC", VA = "0x7BBBEFCBCC")]
		private void RefreshCurrentTabContent()
		{
		}

		// Token: 0x06009084 RID: 36996 RVA: 0x00026838 File Offset: 0x00024A38
		[Token(Token = "0x6009084")]
		[Address(RVA = "0x16FDD04", Offset = "0x16FDD04", VA = "0x7BBBEFDD04", Slot = "40")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06009085 RID: 36997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009085")]
		[Address(RVA = "0x16FDD88", Offset = "0x16FDD88", VA = "0x7BBBEFDD88", Slot = "39")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06009086 RID: 36998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009086")]
		[Address(RVA = "0x16FDE34", Offset = "0x16FDE34", VA = "0x7BBBEFDE34")]
		public UIPaymentController()
		{
		}

		// Token: 0x04009C22 RID: 39970
		[Token(Token = "0x4009C22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly UIPaymentController.Tab[] TAB_ORDER;

		// Token: 0x04009C23 RID: 39971
		[Token(Token = "0x4009C23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly Dictionary<UIPaymentController.Tab, UIPaymentController.TabInfo> TAB_INFO;

		// Token: 0x04009C24 RID: 39972
		[Token(Token = "0x4009C24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Dictionary<UIPaymentController.Tab, UIPaymentController.PaymentTabContentController> m_Tabs;

		// Token: 0x04009C25 RID: 39973
		[Token(Token = "0x4009C25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private UIPaymentController.Tab m_CurrentTab;

		// Token: 0x04009C26 RID: 39974
		[Token(Token = "0x4009C26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private bool m_DebtMode;

		// Token: 0x04009C27 RID: 39975
		[Token(Token = "0x4009C27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private UIPaymentView m_View;

		// Token: 0x04009C28 RID: 39976
		[Token(Token = "0x4009C28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private readonly Dictionary<UIPaymentController.Tab, UIPaymentTabItemController> m_TabItems;

		// Token: 0x02001ABF RID: 6847
		[Token(Token = "0x2001ABF")]
		public enum Tab
		{
			// Token: 0x04009C2A RID: 39978
			[Token(Token = "0x4009C2A")]
			None,
			// Token: 0x04009C2B RID: 39979
			[Token(Token = "0x4009C2B")]
			IAP,
			// Token: 0x04009C2C RID: 39980
			[Token(Token = "0x4009C2C")]
			RebateCard,
			// Token: 0x04009C2D RID: 39981
			[Token(Token = "0x4009C2D")]
			Bundle,
			// Token: 0x04009C2E RID: 39982
			[Token(Token = "0x4009C2E")]
			FirstTime,
			// Token: 0x04009C2F RID: 39983
			[Token(Token = "0x4009C2F")]
			Total,
			// Token: 0x04009C30 RID: 39984
			[Token(Token = "0x4009C30")]
			Activity,
			// Token: 0x04009C31 RID: 39985
			[Token(Token = "0x4009C31")]
			Shop,
			// Token: 0x04009C32 RID: 39986
			[Token(Token = "0x4009C32")]
			DiamondEvent,
			// Token: 0x04009C33 RID: 39987
			[Token(Token = "0x4009C33")]
			Subscription,
			// Token: 0x04009C34 RID: 39988
			[Token(Token = "0x4009C34")]
			GrowthFund
		}

		// Token: 0x02001AC0 RID: 6848
		[Token(Token = "0x2001AC0")]
		public class TabInfo
		{
			// Token: 0x06009088 RID: 37000 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009088")]
			[Address(RVA = "0x1F2150C", Offset = "0x1F2150C", VA = "0x7BBC72150C")]
			public TabInfo()
			{
			}

			// Token: 0x04009C35 RID: 39989
			[Token(Token = "0x4009C35")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string NameLocKey;

			// Token: 0x04009C36 RID: 39990
			[Token(Token = "0x4009C36")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ETipsType TipsType;

			// Token: 0x04009C37 RID: 39991
			[Token(Token = "0x4009C37")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Func<bool> Visible;

			// Token: 0x04009C38 RID: 39992
			[Token(Token = "0x4009C38")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string NoteLocKey;

			// Token: 0x04009C39 RID: 39993
			[Token(Token = "0x4009C39")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool LogClick;
		}

		// Token: 0x02001AC1 RID: 6849
		[Token(Token = "0x2001AC1")]
		public class PaymentGotoParams
		{
			// Token: 0x06009089 RID: 37001 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009089")]
			[Address(RVA = "0x1F214F4", Offset = "0x1F214F4", VA = "0x7BBC7214F4")]
			public PaymentGotoParams()
			{
			}

			// Token: 0x04009C3A RID: 39994
			[Token(Token = "0x4009C3A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public uint? SubscriptionHubStoreId;

			// Token: 0x04009C3B RID: 39995
			[Token(Token = "0x4009C3B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public UIPaymentBundleType m_BundleType;
		}

		// Token: 0x02001AC2 RID: 6850
		[Token(Token = "0x2001AC2")]
		[Attribute(Name = "AddComponentMenu", RVA = "0x10F8A1C", Offset = "0x10F8A1C")]
		public class PaymentTabContentController : UIBaseController
		{
			// Token: 0x0600908A RID: 37002 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600908A")]
			[Address(RVA = "0x1F214FC", Offset = "0x1F214FC", VA = "0x7BBC7214FC", Slot = "28")]
			public virtual void GotoByParams(UIPaymentController.PaymentGotoParams parameters)
			{
			}

			// Token: 0x0600908B RID: 37003 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600908B")]
			[Address(RVA = "0x1F21500", Offset = "0x1F21500", VA = "0x7BBC721500", Slot = "29")]
			public virtual void RefreshContent()
			{
			}

			// Token: 0x0600908C RID: 37004 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600908C")]
			[Address(RVA = "0x1F21504", Offset = "0x1F21504", VA = "0x7BBC721504")]
			public PaymentTabContentController()
			{
			}
		}

		// Token: 0x02001AC3 RID: 6851
		[Token(Token = "0x2001AC3")]
		public class ImageIterator
		{
			// Token: 0x0600908D RID: 37005 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600908D")]
			[Address(RVA = "0x1F20D14", Offset = "0x1F20D14", VA = "0x7BBC720D14")]
			private ImageIterator()
			{
			}

			// Token: 0x170009F7 RID: 2551
			// (get) Token: 0x0600908E RID: 37006 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170009F7")]
			public static UIPaymentController.ImageIterator I
			{
				[Token(Token = "0x600908E")]
				[Address(RVA = "0x1F20DAC", Offset = "0x1F20DAC", VA = "0x7BBC720DAC")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600908F RID: 37007 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600908F")]
			[Address(RVA = "0x1F210C0", Offset = "0x1F210C0", VA = "0x7BBC7210C0")]
			public string Next(UIPaymentController.ImageIterator.ImageType type)
			{
				return null;
			}

			// Token: 0x04009C3C RID: 39996
			[Token(Token = "0x4009C3C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static UIPaymentController.ImageIterator _I;

			// Token: 0x04009C3D RID: 39997
			[Token(Token = "0x4009C3D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Dictionary<UIPaymentController.ImageIterator.ImageType, int> PoolState;

			// Token: 0x04009C3E RID: 39998
			[Token(Token = "0x4009C3E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Dictionary<UIPaymentController.ImageIterator.ImageType, List<string>> IndexPool;

			// Token: 0x02001AC4 RID: 6852
			[Token(Token = "0x2001AC4")]
			public enum ImageType
			{
				// Token: 0x04009C40 RID: 40000
				[Token(Token = "0x4009C40")]
				MainImage,
				// Token: 0x04009C41 RID: 40001
				[Token(Token = "0x4009C41")]
				SubImage
			}

			// Token: 0x02001AC5 RID: 6853
			[Token(Token = "0x2001AC5")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F8A54", Offset = "0x10F8A54")]
			[Serializable]
			private sealed class <>c
			{
				// Token: 0x06009091 RID: 37009 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6009091")]
				[Address(RVA = "0x1F2139C", Offset = "0x1F2139C", VA = "0x7BBC72139C")]
				public <>c()
				{
				}

				// Token: 0x06009092 RID: 37010 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6009092")]
				[Address(RVA = "0x1F213A4", Offset = "0x1F213A4", VA = "0x7BBC7213A4")]
				internal string <get_I>b__4_0(CSVBaseData csvBaseData)
				{
					return null;
				}

				// Token: 0x06009093 RID: 37011 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6009093")]
				[Address(RVA = "0x1F2144C", Offset = "0x1F2144C", VA = "0x7BBC72144C")]
				internal string <get_I>b__4_1(CSVBaseData csvBaseData)
				{
					return null;
				}

				// Token: 0x04009C42 RID: 40002
				[Token(Token = "0x4009C42")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public static readonly UIPaymentController.ImageIterator.<>c <>9;

				// Token: 0x04009C43 RID: 40003
				[Token(Token = "0x4009C43")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public static Converter<CSVBaseData, string> <>9__4_0;

				// Token: 0x04009C44 RID: 40004
				[Token(Token = "0x4009C44")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public static Converter<CSVBaseData, string> <>9__4_1;
			}
		}

		// Token: 0x02001AC6 RID: 6854
		[Token(Token = "0x2001AC6")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F8A64", Offset = "0x10F8A64")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06009095 RID: 37013 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009095")]
			[Address(RVA = "0x1F203D8", Offset = "0x1F203D8", VA = "0x7BBC7203D8")]
			public <>c()
			{
			}

			// Token: 0x06009096 RID: 37014 RVA: 0x00026850 File Offset: 0x00024A50
			[Token(Token = "0x6009096")]
			[Address(RVA = "0x1F203E0", Offset = "0x1F203E0", VA = "0x7BBC7203E0")]
			internal bool <get_DefaultTab>b__6_0(UIPaymentController.Tab t)
			{
				return default(bool);
			}

			// Token: 0x06009097 RID: 37015 RVA: 0x00026868 File Offset: 0x00024A68
			[Token(Token = "0x6009097")]
			[Address(RVA = "0x1F203F8", Offset = "0x1F203F8", VA = "0x7BBC7203F8")]
			internal bool <.cctor>b__32_0()
			{
				return default(bool);
			}

			// Token: 0x06009098 RID: 37016 RVA: 0x00026880 File Offset: 0x00024A80
			[Token(Token = "0x6009098")]
			[Address(RVA = "0x1F20400", Offset = "0x1F20400", VA = "0x7BBC720400")]
			internal bool <.cctor>b__32_1()
			{
				return default(bool);
			}

			// Token: 0x06009099 RID: 37017 RVA: 0x00026898 File Offset: 0x00024A98
			[Token(Token = "0x6009099")]
			[Address(RVA = "0x1F204A0", Offset = "0x1F204A0", VA = "0x7BBC7204A0")]
			internal bool <.cctor>b__32_2()
			{
				return default(bool);
			}

			// Token: 0x0600909A RID: 37018 RVA: 0x000268B0 File Offset: 0x00024AB0
			[Token(Token = "0x600909A")]
			[Address(RVA = "0x1F2057C", Offset = "0x1F2057C", VA = "0x7BBC72057C")]
			internal bool <.cctor>b__32_3()
			{
				return default(bool);
			}

			// Token: 0x0600909B RID: 37019 RVA: 0x000268C8 File Offset: 0x00024AC8
			[Token(Token = "0x600909B")]
			[Address(RVA = "0x1F20658", Offset = "0x1F20658", VA = "0x7BBC720658")]
			internal bool <.cctor>b__32_4()
			{
				return default(bool);
			}

			// Token: 0x0600909C RID: 37020 RVA: 0x000268E0 File Offset: 0x00024AE0
			[Token(Token = "0x600909C")]
			[Address(RVA = "0x1F20734", Offset = "0x1F20734", VA = "0x7BBC720734")]
			internal bool <.cctor>b__32_5()
			{
				return default(bool);
			}

			// Token: 0x0600909D RID: 37021 RVA: 0x000268F8 File Offset: 0x00024AF8
			[Token(Token = "0x600909D")]
			[Address(RVA = "0x1F2085C", Offset = "0x1F2085C", VA = "0x7BBC72085C")]
			internal bool <.cctor>b__32_6()
			{
				return default(bool);
			}

			// Token: 0x0600909E RID: 37022 RVA: 0x00026910 File Offset: 0x00024B10
			[Token(Token = "0x600909E")]
			[Address(RVA = "0x1F2095C", Offset = "0x1F2095C", VA = "0x7BBC72095C")]
			internal bool <.cctor>b__32_7()
			{
				return default(bool);
			}

			// Token: 0x0600909F RID: 37023 RVA: 0x00026928 File Offset: 0x00024B28
			[Token(Token = "0x600909F")]
			[Address(RVA = "0x1F20A80", Offset = "0x1F20A80", VA = "0x7BBC720A80")]
			internal bool <.cctor>b__32_8()
			{
				return default(bool);
			}

			// Token: 0x04009C45 RID: 40005
			[Token(Token = "0x4009C45")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly UIPaymentController.<>c <>9;

			// Token: 0x04009C46 RID: 40006
			[Token(Token = "0x4009C46")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<UIPaymentController.Tab, bool> <>9__6_0;
		}
	}
}
