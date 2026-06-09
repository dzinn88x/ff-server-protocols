using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020025E5 RID: 9701
	[Token(Token = "0x20025E5")]
	public class GameStartup : MonoBehaviour
	{
		// Token: 0x0600C837 RID: 51255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C837")]
		[Address(RVA = "0x1B72794", Offset = "0x1B72794", VA = "0x7BBC372794")]
		private void Awake()
		{
		}

		// Token: 0x0600C838 RID: 51256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C838")]
		[Address(RVA = "0x1B72B18", Offset = "0x1B72B18", VA = "0x7BBC372B18")]
		private void Start()
		{
		}

		// Token: 0x0600C839 RID: 51257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C839")]
		[Address(RVA = "0x1B72EB0", Offset = "0x1B72EB0", VA = "0x7BBC372EB0")]
		private void Update()
		{
		}

		// Token: 0x0600C83A RID: 51258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C83A")]
		[Address(RVA = "0x1B72EE0", Offset = "0x1B72EE0", VA = "0x7BBC372EE0")]
		public void Quit(string str)
		{
		}

		// Token: 0x0600C83B RID: 51259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C83B")]
		[Address(RVA = "0x1B72EE8", Offset = "0x1B72EE8", VA = "0x7BBC372EE8")]
		private void OnApplicationQuit()
		{
		}

		// Token: 0x0600C83C RID: 51260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C83C")]
		[Address(RVA = "0x1B72F98", Offset = "0x1B72F98", VA = "0x7BBC372F98")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1147F8C", Offset = "0x1147F8C")]
		protected IEnumerator CheckAndDownloadOBB()
		{
			return null;
		}

		// Token: 0x0600C83D RID: 51261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C83D")]
		[Address(RVA = "0x1B73038", Offset = "0x1B73038", VA = "0x7BBC373038")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1147FF0", Offset = "0x1147FF0")]
		protected IEnumerator WaitingForFetchingOBB()
		{
			return null;
		}

		// Token: 0x17000D80 RID: 3456
		// (get) Token: 0x0600C83E RID: 51262 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600C83F RID: 51263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000D80")]
		private string LocalLanguageCheckFlag
		{
			[Token(Token = "0x600C83E")]
			[Address(RVA = "0x1B730D8", Offset = "0x1B730D8", VA = "0x7BBC3730D8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600C83F")]
			[Address(RVA = "0x1B7314C", Offset = "0x1B7314C", VA = "0x7BBC37314C")]
			set
			{
			}
		}

		// Token: 0x17000D81 RID: 3457
		// (get) Token: 0x0600C840 RID: 51264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D81")]
		private string RemoteLanguageCheckFlag
		{
			[Token(Token = "0x600C840")]
			[Address(RVA = "0x1B731C4", Offset = "0x1B731C4", VA = "0x7BBC3731C4")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600C841 RID: 51265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C841")]
		[Address(RVA = "0x1B73288", Offset = "0x1B73288", VA = "0x7BBC373288")]
		private void CheckAndAdjustLanguage()
		{
		}

		// Token: 0x0600C842 RID: 51266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C842")]
		[Address(RVA = "0x1B7345C", Offset = "0x1B7345C", VA = "0x7BBC37345C")]
		public void StartGame()
		{
		}

		// Token: 0x0600C843 RID: 51267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C843")]
		[Address(RVA = "0x1B73B44", Offset = "0x1B73B44", VA = "0x7BBC373B44")]
		public void Restart()
		{
		}

		// Token: 0x0600C844 RID: 51268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C844")]
		[Address(RVA = "0x1B73D34", Offset = "0x1B73D34", VA = "0x7BBC373D34")]
		public void CloseLauncher()
		{
		}

		// Token: 0x0600C845 RID: 51269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C845")]
		[Address(RVA = "0x1B73974", Offset = "0x1B73974", VA = "0x7BBC373974")]
		public void StartLauncher(bool isRestart)
		{
		}

		// Token: 0x0600C846 RID: 51270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C846")]
		[Address(RVA = "0x1B73DD4", Offset = "0x1B73DD4", VA = "0x7BBC373DD4")]
		private void LaunchGame(bool isSoftRestart)
		{
		}

		// Token: 0x0600C847 RID: 51271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C847")]
		[Address(RVA = "0x1B74110", Offset = "0x1B74110", VA = "0x7BBC374110")]
		public void GetConfigServerData()
		{
		}

		// Token: 0x0600C848 RID: 51272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C848")]
		[Address(RVA = "0x1B73968", Offset = "0x1B73968", VA = "0x7BBC373968")]
		private UnityEngine.Object LoadLocalResource(string path)
		{
			return null;
		}

		// Token: 0x0600C849 RID: 51273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C849")]
		private T CreateUI<T>(Transform root, string path) where T : UIBaseController
		{
			return null;
		}

		// Token: 0x0600C84A RID: 51274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C84A")]
		[Address(RVA = "0x1B741E4", Offset = "0x1B741E4", VA = "0x7BBC3741E4")]
		private UIBaseController CreateUI(Transform root, string path, Type classType)
		{
			return null;
		}

		// Token: 0x0600C84B RID: 51275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C84B")]
		[Address(RVA = "0x1B74460", Offset = "0x1B74460", VA = "0x7BBC374460")]
		public GameStartup()
		{
		}

		// Token: 0x0600C84D RID: 51277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C84D")]
		[Address(RVA = "0x1B74578", Offset = "0x1B74578", VA = "0x7BBC374578")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1148054", Offset = "0x1148054")]
		private void <Start>b__17_0(Dictionary<PermissionUtility.Permission, bool> result)
		{
		}

		// Token: 0x0400FA94 RID: 64148
		[Token(Token = "0x400FA94")]
		[FieldOffset(Offset = "0x0")]
		public static GameStartup instance;

		// Token: 0x0400FA95 RID: 64149
		[Token(Token = "0x400FA95")]
		[FieldOffset(Offset = "0x18")]
		private bool m_IsEnterGame;

		// Token: 0x0400FA96 RID: 64150
		[Token(Token = "0x400FA96")]
		[FieldOffset(Offset = "0x19")]
		public bool UseAssetBundle;

		// Token: 0x0400FA97 RID: 64151
		[Token(Token = "0x400FA97")]
		[FieldOffset(Offset = "0x1A")]
		public bool MuteSound;

		// Token: 0x0400FA98 RID: 64152
		[Token(Token = "0x400FA98")]
		[FieldOffset(Offset = "0x20")]
		public string DevId;

		// Token: 0x0400FA99 RID: 64153
		[Token(Token = "0x400FA99")]
		[FieldOffset(Offset = "0x28")]
		public bool ShowDebugInfo;

		// Token: 0x0400FA9A RID: 64154
		[Token(Token = "0x400FA9A")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x11308DC", Offset = "0x11308DC")]
		public GameStartup.EGameServerAddress m_gameServer;

		// Token: 0x0400FA9B RID: 64155
		[Token(Token = "0x400FA9B")]
		[FieldOffset(Offset = "0x30")]
		public string CDNAddr;

		// Token: 0x0400FA9C RID: 64156
		[Token(Token = "0x400FA9C")]
		[FieldOffset(Offset = "0x38")]
		public string VerAddr;

		// Token: 0x0400FA9D RID: 64157
		[Token(Token = "0x400FA9D")]
		[FieldOffset(Offset = "0x40")]
		public string GatewayAddr;

		// Token: 0x0400FA9E RID: 64158
		[Token(Token = "0x400FA9E")]
		[FieldOffset(Offset = "0x48")]
		public bool SkipVersionCheck;

		// Token: 0x0400FA9F RID: 64159
		[Token(Token = "0x400FA9F")]
		[FieldOffset(Offset = "0x49")]
		public bool ShowTutorial;

		// Token: 0x0400FAA0 RID: 64160
		[Token(Token = "0x400FAA0")]
		[FieldOffset(Offset = "0x50")]
		public ShaderVariantCollection ShaderCollection;

		// Token: 0x0400FAA1 RID: 64161
		[Token(Token = "0x400FAA1")]
		[FieldOffset(Offset = "0x58")]
		private COWGameEntry m_MainEntry;

		// Token: 0x0400FAA2 RID: 64162
		[Token(Token = "0x400FAA2")]
		[FieldOffset(Offset = "0x60")]
		private UILauncherController m_LaucherController;

		// Token: 0x0400FAA3 RID: 64163
		[Token(Token = "0x400FAA3")]
		[FieldOffset(Offset = "0x68")]
		private string m_ExpansionPath;

		// Token: 0x0400FAA4 RID: 64164
		[Token(Token = "0x400FAA4")]
		private const string PLAYER_PREF_KEY_LANGUAGE_CHECK_FLAG = "CHECK_AND_ADJUST_LANGUAGE_FLAG";

		// Token: 0x0400FAA5 RID: 64165
		[Token(Token = "0x400FAA5")]
		[FieldOffset(Offset = "0x70")]
		private readonly string[] DONT_DESTROY_RESOURCES;

		// Token: 0x020025E6 RID: 9702
		[Token(Token = "0x20025E6")]
		public enum EGameServerAddress
		{
			// Token: 0x0400FAA7 RID: 64167
			[Token(Token = "0x400FAA7")]
			LOCAL_SERVER,
			// Token: 0x0400FAA8 RID: 64168
			[Token(Token = "0x400FAA8")]
			SBT_SERVER,
			// Token: 0x0400FAA9 RID: 64169
			[Token(Token = "0x400FAA9")]
			LIVE_SERVER,
			// Token: 0x0400FAAA RID: 64170
			[Token(Token = "0x400FAAA")]
			IOS_SERVER,
			// Token: 0x0400FAAB RID: 64171
			[Token(Token = "0x400FAAB")]
			RCT_SERVER,
			// Token: 0x0400FAAC RID: 64172
			[Token(Token = "0x400FAAC")]
			PREVIEW_SERVER,
			// Token: 0x0400FAAD RID: 64173
			[Token(Token = "0x400FAAD")]
			BETA_SERVER,
			// Token: 0x0400FAAE RID: 64174
			[Token(Token = "0x400FAAE")]
			EXP_SERVER,
			// Token: 0x0400FAAF RID: 64175
			[Token(Token = "0x400FAAF")]
			ART_SERVER,
			// Token: 0x0400FAB0 RID: 64176
			[Token(Token = "0x400FAB0")]
			DESIGN_SERVER,
			// Token: 0x0400FAB1 RID: 64177
			[Token(Token = "0x400FAB1")]
			ACTION_SERVER
		}

		// Token: 0x020025E7 RID: 9703
		[Token(Token = "0x20025E7")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FDE94", Offset = "0x10FDE94")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600C84F RID: 51279 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C84F")]
			[Address(RVA = "0x1B746B4", Offset = "0x1B746B4", VA = "0x7BBC3746B4")]
			public <>c()
			{
			}

			// Token: 0x0600C850 RID: 51280 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C850")]
			[Address(RVA = "0x1B746BC", Offset = "0x1B746BC", VA = "0x7BBC3746BC")]
			internal void <Awake>b__16_0(DebugLogType logType, string content)
			{
			}

			// Token: 0x0400FAB2 RID: 64178
			[Token(Token = "0x400FAB2")]
			[FieldOffset(Offset = "0x0")]
			public static readonly GameStartup.<>c <>9;

			// Token: 0x0400FAB3 RID: 64179
			[Token(Token = "0x400FAB3")]
			[FieldOffset(Offset = "0x8")]
			public static NGUITools.OnLogCallback <>9__16_0;
		}

		// Token: 0x020025E8 RID: 9704
		[Token(Token = "0x20025E8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FDEA4", Offset = "0x10FDEA4")]
		private sealed class <CheckAndDownloadOBB>d__22 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x0600C851 RID: 51281 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C851")]
			[Address(RVA = "0x1B7300C", Offset = "0x1B7300C", VA = "0x7BBC37300C")]
			[DebuggerHidden]
			public <CheckAndDownloadOBB>d__22(int <>1__state)
			{
			}

			// Token: 0x0600C852 RID: 51282 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C852")]
			[Address(RVA = "0x1B7485C", Offset = "0x1B7485C", VA = "0x7BBC37485C", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x0600C853 RID: 51283 RVA: 0x000361C8 File Offset: 0x000343C8
			[Token(Token = "0x600C853")]
			[Address(RVA = "0x1B74860", Offset = "0x1B74860", VA = "0x7BBC374860", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000D82 RID: 3458
			// (get) Token: 0x0600C854 RID: 51284 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000D82")]
			private object Current
			{
				[Token(Token = "0x600C854")]
				[Address(RVA = "0x1B74C58", Offset = "0x1B74C58", VA = "0x7BBC374C58", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0600C855 RID: 51285 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C855")]
			[Address(RVA = "0x1B74C60", Offset = "0x1B74C60", VA = "0x7BBC374C60", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000D83 RID: 3459
			// (get) Token: 0x0600C856 RID: 51286 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000D83")]
			private object Current
			{
				[Token(Token = "0x600C856")]
				[Address(RVA = "0x1B74CC8", Offset = "0x1B74CC8", VA = "0x7BBC374CC8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0400FAB4 RID: 64180
			[Token(Token = "0x400FAB4")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0400FAB5 RID: 64181
			[Token(Token = "0x400FAB5")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x0400FAB6 RID: 64182
			[Token(Token = "0x400FAB6")]
			[FieldOffset(Offset = "0x20")]
			public GameStartup <>4__this;
		}

		// Token: 0x020025E9 RID: 9705
		[Token(Token = "0x20025E9")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FDEB4", Offset = "0x10FDEB4")]
		private sealed class <WaitingForFetchingOBB>d__23 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x0600C857 RID: 51287 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C857")]
			[Address(RVA = "0x1B730AC", Offset = "0x1B730AC", VA = "0x7BBC3730AC")]
			[DebuggerHidden]
			public <WaitingForFetchingOBB>d__23(int <>1__state)
			{
			}

			// Token: 0x0600C858 RID: 51288 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C858")]
			[Address(RVA = "0x1B74CD0", Offset = "0x1B74CD0", VA = "0x7BBC374CD0", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x0600C859 RID: 51289 RVA: 0x000361E0 File Offset: 0x000343E0
			[Token(Token = "0x600C859")]
			[Address(RVA = "0x1B74CD4", Offset = "0x1B74CD4", VA = "0x7BBC374CD4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000D84 RID: 3460
			// (get) Token: 0x0600C85A RID: 51290 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000D84")]
			private object Current
			{
				[Token(Token = "0x600C85A")]
				[Address(RVA = "0x1B74EF0", Offset = "0x1B74EF0", VA = "0x7BBC374EF0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0600C85B RID: 51291 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C85B")]
			[Address(RVA = "0x1B74EF8", Offset = "0x1B74EF8", VA = "0x7BBC374EF8", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000D85 RID: 3461
			// (get) Token: 0x0600C85C RID: 51292 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000D85")]
			private object Current
			{
				[Token(Token = "0x600C85C")]
				[Address(RVA = "0x1B74F60", Offset = "0x1B74F60", VA = "0x7BBC374F60", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0400FAB7 RID: 64183
			[Token(Token = "0x400FAB7")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0400FAB8 RID: 64184
			[Token(Token = "0x400FAB8")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x0400FAB9 RID: 64185
			[Token(Token = "0x400FAB9")]
			[FieldOffset(Offset = "0x20")]
			public GameStartup <>4__this;
		}

		// Token: 0x020025EA RID: 9706
		[Token(Token = "0x20025EA")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FDEC4", Offset = "0x10FDEC4")]
		private sealed class <>c__DisplayClass34_0
		{
			// Token: 0x0600C85D RID: 51293 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C85D")]
			[Address(RVA = "0x1B73DCC", Offset = "0x1B73DCC", VA = "0x7BBC373DCC")]
			public <>c__DisplayClass34_0()
			{
			}

			// Token: 0x0600C85E RID: 51294 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C85E")]
			[Address(RVA = "0x1B74784", Offset = "0x1B74784", VA = "0x7BBC374784")]
			internal void <StartLauncher>b__0()
			{
			}

			// Token: 0x0600C85F RID: 51295 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600C85F")]
			[Address(RVA = "0x1B747BC", Offset = "0x1B747BC", VA = "0x7BBC3747BC")]
			internal UIBaseController <StartLauncher>b__1(string path, Type type)
			{
				return null;
			}

			// Token: 0x0400FABA RID: 64186
			[Token(Token = "0x400FABA")]
			[FieldOffset(Offset = "0x10")]
			public GameStartup <>4__this;

			// Token: 0x0400FABB RID: 64187
			[Token(Token = "0x400FABB")]
			[FieldOffset(Offset = "0x18")]
			public bool isRestart;
		}
	}
}
