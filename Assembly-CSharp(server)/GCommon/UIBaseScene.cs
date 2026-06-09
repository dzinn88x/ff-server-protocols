using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x02001017 RID: 4119
	[Token(Token = "0x2001017")]
	public class UIBaseScene
	{
		// Token: 0x17000730 RID: 1840
		// (get) Token: 0x06003E06 RID: 15878 RVA: 0x00013500 File Offset: 0x00011700
		[Token(Token = "0x17000730")]
		public bool Initialized
		{
			[Token(Token = "0x6003E06")]
			[Address(RVA = "0x2024974", Offset = "0x2024974", VA = "0x7BBC824974")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000731 RID: 1841
		// (get) Token: 0x06003E07 RID: 15879 RVA: 0x00013518 File Offset: 0x00011718
		[Token(Token = "0x17000731")]
		public Vector2 WindowsSize
		{
			[Token(Token = "0x6003E07")]
			[Address(RVA = "0x202497C", Offset = "0x202497C", VA = "0x7BBC82497C")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x17000732 RID: 1842
		// (get) Token: 0x06003E08 RID: 15880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000732")]
		public UIPopupWindowController CurrentPopupController
		{
			[Token(Token = "0x6003E08")]
			[Address(RVA = "0x2024984", Offset = "0x2024984", VA = "0x7BBC824984")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003E09 RID: 15881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E09")]
		[Address(RVA = "0x2024AF4", Offset = "0x2024AF4", VA = "0x7BBC824AF4")]
		public void Init()
		{
		}

		// Token: 0x06003E0A RID: 15882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E0A")]
		[Address(RVA = "0x2025004", Offset = "0x2025004", VA = "0x7BBC825004", Slot = "4")]
		public virtual void Destory()
		{
		}

		// Token: 0x06003E0B RID: 15883 RVA: 0x00013530 File Offset: 0x00011730
		[Token(Token = "0x6003E0B")]
		[Address(RVA = "0x2025204", Offset = "0x2025204", VA = "0x7BBC825204")]
		public bool IsDuringSceneDestroy()
		{
			return default(bool);
		}

		// Token: 0x06003E0C RID: 15884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E0C")]
		public virtual T PushNavigation<T>(UINavigationData navigationData, bool isRoot = false) where T : UIBaseNavigationController
		{
			return null;
		}

		// Token: 0x06003E0D RID: 15885 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E0D")]
		[Address(RVA = "0x202520C", Offset = "0x202520C", VA = "0x7BBC82520C")]
		public UINavigationData PopNavigation()
		{
			return null;
		}

		// Token: 0x06003E0E RID: 15886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E0E")]
		public void CloseNavigation<T>() where T : UIBaseNavigationController
		{
		}

		// Token: 0x06003E0F RID: 15887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E0F")]
		public void PopToNavigation<T>() where T : UIBaseNavigationController
		{
		}

		// Token: 0x17000733 RID: 1843
		// (get) Token: 0x06003E10 RID: 15888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000733")]
		public Type CurrentNavigationType
		{
			[Token(Token = "0x6003E10")]
			[Address(RVA = "0x20255B4", Offset = "0x20255B4", VA = "0x7BBC8255B4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003E11 RID: 15889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E11")]
		[Address(RVA = "0x2025728", Offset = "0x2025728", VA = "0x7BBC825728")]
		public UINavigationData GetCurrentUINavigationData()
		{
			return null;
		}

		// Token: 0x06003E12 RID: 15890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E12")]
		[Address(RVA = "0x202565C", Offset = "0x202565C", VA = "0x7BBC82565C")]
		public UIBaseNavigationController GetCurrentUINavigationController()
		{
			return null;
		}

		// Token: 0x06003E13 RID: 15891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E13")]
		[Address(RVA = "0x20257C4", Offset = "0x20257C4", VA = "0x7BBC8257C4")]
		public List<UIPopupWindowController> GetInGamePopupWindows()
		{
			return null;
		}

		// Token: 0x06003E14 RID: 15892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E14")]
		public virtual T ShowPopupWindow<T>() where T : UIPopupWindowController
		{
			return null;
		}

		// Token: 0x06003E15 RID: 15893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E15")]
		[Address(RVA = "0x20257CC", Offset = "0x20257CC", VA = "0x7BBC8257CC")]
		public void CloseAllPopups()
		{
		}

		// Token: 0x06003E16 RID: 15894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E16")]
		public void CloseAllPopups<T>() where T : UIPopupWindowController
		{
		}

		// Token: 0x06003E17 RID: 15895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E17")]
		public T Open3DUI<T>(Transform parent, bool isChildCon = false, bool isQueued = false, [Optional] Type forceType) where T : UIBaseController
		{
			return null;
		}

		// Token: 0x06003E18 RID: 15896 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E18")]
		public T Open3DUI<T>(Transform parent, Vector3 localPosition, EUIAnchor anchor, bool isChildCon = false, bool isQueued = false) where T : UIBaseController
		{
			return null;
		}

		// Token: 0x06003E19 RID: 15897 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E19")]
		public T OpenUI<T>(Transform parent, bool isChildCon = false, bool noCache = false) where T : UIBaseController
		{
			return null;
		}

		// Token: 0x06003E1A RID: 15898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E1A")]
		[Address(RVA = "0x2025898", Offset = "0x2025898", VA = "0x7BBC825898")]
		public UIBaseController OpenUI(Type uiBaseControllerType, Transform parent, bool isChildCon = false, bool noCache = false)
		{
			return null;
		}

		// Token: 0x06003E1B RID: 15899 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E1B")]
		public T OpenUI<T>(Transform parent, Vector3 localPosition, EUIAnchor anchor, bool isChildCon = false, bool noCache = false) where T : UIBaseController
		{
			return null;
		}

		// Token: 0x06003E1C RID: 15900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E1C")]
		[Address(RVA = "0x20221DC", Offset = "0x20221DC", VA = "0x7BBC8221DC")]
		public void RemoveRootController(UIBaseController uiController)
		{
		}

		// Token: 0x06003E1D RID: 15901 RVA: 0x00013548 File Offset: 0x00011748
		[Token(Token = "0x6003E1D")]
		[Address(RVA = "0x2025EC8", Offset = "0x2025EC8", VA = "0x7BBC825EC8")]
		public Vector3 GetTopLeftTrans()
		{
			return default(Vector3);
		}

		// Token: 0x06003E1E RID: 15902 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E1E")]
		[Address(RVA = "0x2026024", Offset = "0x2026024", VA = "0x7BBC826024")]
		public Transform GetAnchor(Transform parent, EUIAnchor anchor, bool autoCreate = true)
		{
			return null;
		}

		// Token: 0x06003E1F RID: 15903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E1F")]
		[Address(RVA = "0x2023334", Offset = "0x2023334", VA = "0x7BBC823334")]
		public void AddUINavigationController(UIBaseNavigationController navigation)
		{
		}

		// Token: 0x06003E20 RID: 15904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E20")]
		[Address(RVA = "0x2024864", Offset = "0x2024864", VA = "0x7BBC824864")]
		public void RemoveUINavigationController(UIBaseNavigationController navigation)
		{
		}

		// Token: 0x06003E21 RID: 15905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E21")]
		[Address(RVA = "0x20263F4", Offset = "0x20263F4", VA = "0x7BBC8263F4")]
		public void RemovePopupWindow(UIPopupWindowController popupWindow)
		{
		}

		// Token: 0x06003E22 RID: 15906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E22")]
		private T CreateUI<T>(bool noCache = false) where T : UIBaseController
		{
			return null;
		}

		// Token: 0x06003E23 RID: 15907 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E23")]
		[Address(RVA = "0x2025B74", Offset = "0x2025B74", VA = "0x7BBC825B74")]
		private UIBaseController CreateUI(Type uiBaseControllerType, bool noCache = false)
		{
			return null;
		}

		// Token: 0x06003E24 RID: 15908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E24")]
		[Address(RVA = "0x202647C", Offset = "0x202647C", VA = "0x7BBC82647C")]
		public GameObject InstantiateUIPrefab(ResourceID InPrefabResID, bool noCache = false)
		{
			return null;
		}

		// Token: 0x06003E25 RID: 15909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E25")]
		[Address(RVA = "0x20266B0", Offset = "0x20266B0", VA = "0x7BBC8266B0", Slot = "7")]
		protected virtual Transform FindUIRoot()
		{
			return null;
		}

		// Token: 0x06003E26 RID: 15910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E26")]
		[Address(RVA = "0x2024E1C", Offset = "0x2024E1C", VA = "0x7BBC824E1C")]
		private UISprite GetNavigationTransferMask()
		{
			return null;
		}

		// Token: 0x06003E27 RID: 15911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E27")]
		[Address(RVA = "0x2026714", Offset = "0x2026714", VA = "0x7BBC826714")]
		public void SetPreviousActiveGroup(ulong requestCurGroup = 0UL)
		{
		}

		// Token: 0x06003E28 RID: 15912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E28")]
		[Address(RVA = "0x2026AFC", Offset = "0x2026AFC", VA = "0x7BBC826AFC")]
		public void SetActiveGroup(ulong InActiveGroup)
		{
		}

		// Token: 0x06003E29 RID: 15913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E29")]
		[Address(RVA = "0x2026968", Offset = "0x2026968", VA = "0x7BBC826968")]
		private void SetActiveGroupInternal(ulong InActiveGroup)
		{
		}

		// Token: 0x06003E2A RID: 15914 RVA: 0x00013560 File Offset: 0x00011760
		[Token(Token = "0x6003E2A")]
		[Address(RVA = "0x2026C10", Offset = "0x2026C10", VA = "0x7BBC826C10")]
		public ulong CurActiveGroup()
		{
			return 0UL;
		}

		// Token: 0x06003E2B RID: 15915 RVA: 0x00013578 File Offset: 0x00011778
		[Token(Token = "0x6003E2B")]
		[Address(RVA = "0x2026CE8", Offset = "0x2026CE8", VA = "0x7BBC826CE8")]
		public bool IsGroupActive(ulong flag)
		{
			return default(bool);
		}

		// Token: 0x06003E2C RID: 15916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E2C")]
		[Address(RVA = "0x2026DC8", Offset = "0x2026DC8", VA = "0x7BBC826DC8", Slot = "8")]
		protected virtual void OnInit()
		{
		}

		// Token: 0x06003E2D RID: 15917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E2D")]
		[Address(RVA = "0x2026DCC", Offset = "0x2026DCC", VA = "0x7BBC826DCC", Slot = "9")]
		protected virtual void OnDestory()
		{
		}

		// Token: 0x06003E2E RID: 15918 RVA: 0x00013590 File Offset: 0x00011790
		[Token(Token = "0x6003E2E")]
		[Address(RVA = "0x2026DD0", Offset = "0x2026DD0", VA = "0x7BBC826DD0")]
		public float GetPixelSizeAdjustment()
		{
			return 0f;
		}

		// Token: 0x06003E2F RID: 15919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E2F")]
		[Address(RVA = "0x2026E6C", Offset = "0x2026E6C", VA = "0x7BBC826E6C")]
		public void RegisterEscapeHandle(UIBaseScene.EscapeHandle handle)
		{
		}

		// Token: 0x06003E30 RID: 15920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E30")]
		[Address(RVA = "0x2026F08", Offset = "0x2026F08", VA = "0x7BBC826F08")]
		public void UnRegisterEscapeHandle(UIBaseScene.EscapeHandle handle)
		{
		}

		// Token: 0x06003E31 RID: 15921 RVA: 0x000135A8 File Offset: 0x000117A8
		[Token(Token = "0x6003E31")]
		[Address(RVA = "0x2026FA8", Offset = "0x2026FA8", VA = "0x7BBC826FA8")]
		public bool DispatchEscapeHandle()
		{
			return default(bool);
		}

		// Token: 0x06003E32 RID: 15922 RVA: 0x000135C0 File Offset: 0x000117C0
		[Token(Token = "0x6003E32")]
		[Address(RVA = "0x20274B4", Offset = "0x20274B4", VA = "0x7BBC8274B4")]
		public float GetDefaultScreenRatio()
		{
			return 0f;
		}

		// Token: 0x06003E33 RID: 15923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E33")]
		[Address(RVA = "0x20274C0", Offset = "0x20274C0", VA = "0x7BBC8274C0")]
		public void RegisterEnterHandle(UIBaseScene.EnterHandle handle)
		{
		}

		// Token: 0x06003E34 RID: 15924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E34")]
		[Address(RVA = "0x202755C", Offset = "0x202755C", VA = "0x7BBC82755C")]
		public void UnRegisterEnterHandle(UIBaseScene.EnterHandle handle)
		{
		}

		// Token: 0x06003E35 RID: 15925 RVA: 0x000135D8 File Offset: 0x000117D8
		[Token(Token = "0x6003E35")]
		[Address(RVA = "0x20275FC", Offset = "0x20275FC", VA = "0x7BBC8275FC")]
		public bool DispatchEnterHandle()
		{
			return default(bool);
		}

		// Token: 0x06003E36 RID: 15926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E36")]
		[Address(RVA = "0x2027B08", Offset = "0x2027B08", VA = "0x7BBC827B08")]
		public void SetBGBlur(UIPopupWindowBGBlur blur)
		{
		}

		// Token: 0x06003E37 RID: 15927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E37")]
		[Address(RVA = "0x2027B10", Offset = "0x2027B10", VA = "0x7BBC827B10")]
		public void ExecuteBGBlur(GameObject root)
		{
		}

		// Token: 0x06003E38 RID: 15928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E38")]
		[Address(RVA = "0x2027D34", Offset = "0x2027D34", VA = "0x7BBC827D34")]
		public UIBaseScene()
		{
		}

		// Token: 0x04004E96 RID: 20118
		[Token(Token = "0x4004E96")]
		private const int DefaultUIWidth = 1334;

		// Token: 0x04004E97 RID: 20119
		[Token(Token = "0x4004E97")]
		private const int DefaultUIHeight = 750;

		// Token: 0x04004E98 RID: 20120
		[Token(Token = "0x4004E98")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Transform UIRoot;

		// Token: 0x04004E99 RID: 20121
		[Token(Token = "0x4004E99")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static UICamera HUD_UICamera;

		// Token: 0x04004E9A RID: 20122
		[Token(Token = "0x4004E9A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static UIBaseScene Instance;

		// Token: 0x04004E9B RID: 20123
		[Token(Token = "0x4004E9B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static UISprite TransferMask;

		// Token: 0x04004E9C RID: 20124
		[Token(Token = "0x4004E9C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected List<UIBaseController> m_RootControllers;

		// Token: 0x04004E9D RID: 20125
		[Token(Token = "0x4004E9D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected List<UIBaseNavigationController> m_NavigationControllers;

		// Token: 0x04004E9E RID: 20126
		[Token(Token = "0x4004E9E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected List<UIPopupWindowController> m_InGamePopupWindows;

		// Token: 0x04004E9F RID: 20127
		[Token(Token = "0x4004E9F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<ulong> m_ActiveGroupStack;

		// Token: 0x04004EA0 RID: 20128
		[Token(Token = "0x4004EA0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected Vector2 m_WindowsSize;

		// Token: 0x04004EA1 RID: 20129
		[Token(Token = "0x4004EA1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected bool isDuringSceneDestroy;

		// Token: 0x04004EA2 RID: 20130
		[Token(Token = "0x4004EA2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private UIPopupWindowBGBlur cbBlur;

		// Token: 0x04004EA3 RID: 20131
		[Token(Token = "0x4004EA3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static int curNavIndex;

		// Token: 0x04004EA4 RID: 20132
		[Token(Token = "0x4004EA4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool mIsInitialzied;

		// Token: 0x04004EA5 RID: 20133
		[Token(Token = "0x4004EA5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<UIBaseScene.EscapeHandle> m_EscapeHandles;

		// Token: 0x04004EA6 RID: 20134
		[Token(Token = "0x4004EA6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<UIBaseScene.EnterHandle> m_EnterHandles;

		// Token: 0x02001018 RID: 4120
		// (Invoke) Token: 0x06003E3B RID: 15931
		[Token(Token = "0x2001018")]
		public delegate bool EscapeHandle();

		// Token: 0x02001019 RID: 4121
		// (Invoke) Token: 0x06003E3F RID: 15935
		[Token(Token = "0x2001019")]
		public delegate bool EnterHandle();

		// Token: 0x0200101A RID: 4122
		[Token(Token = "0x200101A")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EA6D0", Offset = "0x10EA6D0")]
		private sealed class <>c__DisplayClass56_0
		{
			// Token: 0x06003E42 RID: 15938 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003E42")]
			[Address(RVA = "0x2026960", Offset = "0x2026960", VA = "0x7BBC826960")]
			public <>c__DisplayClass56_0()
			{
			}

			// Token: 0x06003E43 RID: 15939 RVA: 0x000135F0 File Offset: 0x000117F0
			[Token(Token = "0x6003E43")]
			[Address(RVA = "0x2027E70", Offset = "0x2027E70", VA = "0x7BBC827E70")]
			internal bool <SetPreviousActiveGroup>b__0(ulong a)
			{
				return default(bool);
			}

			// Token: 0x04004EA7 RID: 20135
			[Token(Token = "0x4004EA7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ulong requestCurGroup;
		}
	}
}
