using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x02001BBA RID: 7098
	[Token(Token = "0x2001BBA")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FAB9C", Offset = "0x10FAB9C")]
	public class UITurntableSigninController : UIPopupWindowController, IUIModelDataChangeObserver
	{
		// Token: 0x06009961 RID: 39265 RVA: 0x00028608 File Offset: 0x00026808
		[Token(Token = "0x6009961")]
		[Address(RVA = "0x19F4474", Offset = "0x19F4474", VA = "0x7BBC1F4474")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009962 RID: 39266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009962")]
		[Address(RVA = "0x19F44C4", Offset = "0x19F44C4", VA = "0x7BBC1F44C4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009963 RID: 39267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009963")]
		[Address(RVA = "0x19F4AB8", Offset = "0x19F4AB8", VA = "0x7BBC1F4AB8")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1144E94", Offset = "0x1144E94")]
		private IEnumerator WaitInitHttpRequest(HttpRequest request)
		{
			return null;
		}

		// Token: 0x06009964 RID: 39268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009964")]
		[Address(RVA = "0x19F4B7C", Offset = "0x19F4B7C", VA = "0x7BBC1F4B7C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06009965 RID: 39269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009965")]
		[Address(RVA = "0x19F4900", Offset = "0x19F4900", VA = "0x7BBC1F4900")]
		private void InitAwardContainer()
		{
		}

		// Token: 0x06009966 RID: 39270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009966")]
		[Address(RVA = "0x19F4CC4", Offset = "0x19F4CC4", VA = "0x7BBC1F4CC4")]
		private void RefreshPeakDayAward()
		{
		}

		// Token: 0x06009967 RID: 39271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009967")]
		[Address(RVA = "0x19F5230", Offset = "0x19F5230", VA = "0x7BBC1F5230")]
		private void RefreshView()
		{
		}

		// Token: 0x06009968 RID: 39272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009968")]
		[Address(RVA = "0x19F5264", Offset = "0x19F5264", VA = "0x7BBC1F5264")]
		private void RefreshNetworkBg()
		{
		}

		// Token: 0x06009969 RID: 39273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009969")]
		[Address(RVA = "0x19F53FC", Offset = "0x19F53FC", VA = "0x7BBC1F53FC")]
		private void RefreshAwardList()
		{
		}

		// Token: 0x0600996A RID: 39274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600996A")]
		[Address(RVA = "0x19F566C", Offset = "0x19F566C", VA = "0x7BBC1F566C")]
		private void RefreshTime()
		{
		}

		// Token: 0x0600996B RID: 39275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600996B")]
		[Address(RVA = "0x19F5BC0", Offset = "0x19F5BC0", VA = "0x7BBC1F5BC0")]
		private void RefreshSignedAward()
		{
		}

		// Token: 0x0600996C RID: 39276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600996C")]
		[Address(RVA = "0x19F5E18", Offset = "0x19F5E18", VA = "0x7BBC1F5E18")]
		private void ShowGetRewardEffect()
		{
		}

		// Token: 0x0600996D RID: 39277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600996D")]
		[Address(RVA = "0x19F57F8", Offset = "0x19F57F8", VA = "0x7BBC1F57F8")]
		private void RefreshSignBtn()
		{
		}

		// Token: 0x0600996E RID: 39278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600996E")]
		[Address(RVA = "0x19F6090", Offset = "0x19F6090", VA = "0x7BBC1F6090")]
		private void ShowResult(params object[] param)
		{
		}

		// Token: 0x0600996F RID: 39279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600996F")]
		[Address(RVA = "0x19F613C", Offset = "0x19F613C", VA = "0x7BBC1F613C")]
		private void DelayShowReward()
		{
		}

		// Token: 0x06009970 RID: 39280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009970")]
		[Address(RVA = "0x19F6630", Offset = "0x19F6630", VA = "0x7BBC1F6630")]
		private void SetSignBtnState(bool enable)
		{
		}

		// Token: 0x06009971 RID: 39281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009971")]
		[Address(RVA = "0x19F6680", Offset = "0x19F6680", VA = "0x7BBC1F6680")]
		private void OnRuleBtnClick()
		{
		}

		// Token: 0x06009972 RID: 39282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009972")]
		[Address(RVA = "0x19F6684", Offset = "0x19F6684", VA = "0x7BBC1F6684")]
		private void OnSigninBtnClick()
		{
		}

		// Token: 0x06009973 RID: 39283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009973")]
		[Address(RVA = "0x19F6880", Offset = "0x19F6880", VA = "0x7BBC1F6880")]
		private void OnCloseBtnClick()
		{
		}

		// Token: 0x06009974 RID: 39284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009974")]
		[Address(RVA = "0x19F6888", Offset = "0x19F6888", VA = "0x7BBC1F6888", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x06009975 RID: 39285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009975")]
		[Address(RVA = "0x19F6890", Offset = "0x19F6890", VA = "0x7BBC1F6890")]
		private void OnTimeBtnClick()
		{
		}

		// Token: 0x06009976 RID: 39286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009976")]
		[Address(RVA = "0x19F6A18", Offset = "0x19F6A18", VA = "0x7BBC1F6A18")]
		private void OnPeakDayAwardClick()
		{
		}

		// Token: 0x06009977 RID: 39287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009977")]
		[Address(RVA = "0x19F6D88", Offset = "0x19F6D88", VA = "0x7BBC1F6D88", Slot = "40")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06009978 RID: 39288 RVA: 0x00028620 File Offset: 0x00026820
		[Token(Token = "0x6009978")]
		[Address(RVA = "0x19F7018", Offset = "0x19F7018", VA = "0x7BBC1F7018", Slot = "41")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06009979 RID: 39289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009979")]
		[Address(RVA = "0x19F707C", Offset = "0x19F707C", VA = "0x7BBC1F707C")]
		public UITurntableSigninController()
		{
		}

		// Token: 0x0400A0B3 RID: 41139
		[Token(Token = "0x400A0B3")]
		[FieldOffset(Offset = "0x98")]
		private UITurntableSignInView m_View;

		// Token: 0x0400A0B4 RID: 41140
		[Token(Token = "0x400A0B4")]
		[FieldOffset(Offset = "0xA0")]
		private UIModelAnnoucementReward m_ModelAnnoucement;

		// Token: 0x0400A0B5 RID: 41141
		[Token(Token = "0x400A0B5")]
		[FieldOffset(Offset = "0xA8")]
		private UIModelRampage m_ModelRampage;

		// Token: 0x0400A0B6 RID: 41142
		[Token(Token = "0x400A0B6")]
		[FieldOffset(Offset = "0xB0")]
		private List<UITurntableSigninItemController> m_AwardCtrlList;

		// Token: 0x0400A0B7 RID: 41143
		[Token(Token = "0x400A0B7")]
		[FieldOffset(Offset = "0xB8")]
		private List<Transform> m_AwardContainerList;

		// Token: 0x0400A0B8 RID: 41144
		[Token(Token = "0x400A0B8")]
		[FieldOffset(Offset = "0xC0")]
		private List<uint> m_SignIDList;

		// Token: 0x0400A0B9 RID: 41145
		[Token(Token = "0x400A0B9")]
		[FieldOffset(Offset = "0xC8")]
		private uint m_DelayCall;

		// Token: 0x0400A0BA RID: 41146
		[Token(Token = "0x400A0BA")]
		[FieldOffset(Offset = "0xD0")]
		private UIModelActivity m_ModelActivity;

		// Token: 0x0400A0BB RID: 41147
		[Token(Token = "0x400A0BB")]
		[FieldOffset(Offset = "0xD8")]
		private ClientActivityDesc m_PeakDayClientActivityDesc;

		// Token: 0x0400A0BC RID: 41148
		[Token(Token = "0x400A0BC")]
		[FieldOffset(Offset = "0xE0")]
		private bool m_PeakDayAwardClaimed;

		// Token: 0x0400A0BD RID: 41149
		[Token(Token = "0x400A0BD")]
		[FieldOffset(Offset = "0xE8")]
		private UIStandardItemMAXBController m_PeakDayAwardCtrl;

		// Token: 0x0400A0BE RID: 41150
		[Token(Token = "0x400A0BE")]
		[FieldOffset(Offset = "0xF0")]
		private IEnumerator m_WaitInitHttpRequest;

		// Token: 0x02001BBB RID: 7099
		[Token(Token = "0x2001BBB")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FABD4", Offset = "0x10FABD4")]
		private sealed class <WaitInitHttpRequest>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x0600997A RID: 39290 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600997A")]
			[Address(RVA = "0x19F4B50", Offset = "0x19F4B50", VA = "0x7BBC1F4B50")]
			[DebuggerHidden]
			public <WaitInitHttpRequest>d__14(int <>1__state)
			{
			}

			// Token: 0x0600997B RID: 39291 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600997B")]
			[Address(RVA = "0x19F723C", Offset = "0x19F723C", VA = "0x7BBC1F723C", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x0600997C RID: 39292 RVA: 0x00028638 File Offset: 0x00026838
			[Token(Token = "0x600997C")]
			[Address(RVA = "0x19F7240", Offset = "0x19F7240", VA = "0x7BBC1F7240", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000A4E RID: 2638
			// (get) Token: 0x0600997D RID: 39293 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000A4E")]
			private object Current
			{
				[Token(Token = "0x600997D")]
				[Address(RVA = "0x19F72CC", Offset = "0x19F72CC", VA = "0x7BBC1F72CC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0600997E RID: 39294 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600997E")]
			[Address(RVA = "0x19F72D4", Offset = "0x19F72D4", VA = "0x7BBC1F72D4", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000A4F RID: 2639
			// (get) Token: 0x0600997F RID: 39295 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000A4F")]
			private object Current
			{
				[Token(Token = "0x600997F")]
				[Address(RVA = "0x19F733C", Offset = "0x19F733C", VA = "0x7BBC1F733C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0400A0BF RID: 41151
			[Token(Token = "0x400A0BF")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0400A0C0 RID: 41152
			[Token(Token = "0x400A0C0")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x0400A0C1 RID: 41153
			[Token(Token = "0x400A0C1")]
			[FieldOffset(Offset = "0x20")]
			public HttpRequest request;

			// Token: 0x0400A0C2 RID: 41154
			[Token(Token = "0x400A0C2")]
			[FieldOffset(Offset = "0x28")]
			public UITurntableSigninController <>4__this;
		}

		// Token: 0x02001BBC RID: 7100
		[Token(Token = "0x2001BBC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FABE4", Offset = "0x10FABE4")]
		private sealed class <>c__DisplayClass22_0
		{
			// Token: 0x06009980 RID: 39296 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009980")]
			[Address(RVA = "0x19F5DFC", Offset = "0x19F5DFC", VA = "0x7BBC1F5DFC")]
			public <>c__DisplayClass22_0()
			{
			}

			// Token: 0x06009981 RID: 39297 RVA: 0x00028650 File Offset: 0x00026850
			[Token(Token = "0x6009981")]
			[Address(RVA = "0x19F713C", Offset = "0x19F713C", VA = "0x7BBC1F713C")]
			internal bool <RefreshSignedAward>b__0(UITurntableSigninItemController item)
			{
				return default(bool);
			}

			// Token: 0x0400A0C3 RID: 41155
			[Token(Token = "0x400A0C3")]
			[FieldOffset(Offset = "0x10")]
			public uint signID;
		}

		// Token: 0x02001BBD RID: 7101
		[Token(Token = "0x2001BBD")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FABF4", Offset = "0x10FABF4")]
		private sealed class <>c__DisplayClass23_0
		{
			// Token: 0x06009982 RID: 39298 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009982")]
			[Address(RVA = "0x19F6044", Offset = "0x19F6044", VA = "0x7BBC1F6044")]
			public <>c__DisplayClass23_0()
			{
			}

			// Token: 0x06009983 RID: 39299 RVA: 0x00028668 File Offset: 0x00026868
			[Token(Token = "0x6009983")]
			[Address(RVA = "0x19F71B4", Offset = "0x19F71B4", VA = "0x7BBC1F71B4")]
			internal bool <ShowGetRewardEffect>b__0(UITurntableSigninItemController item)
			{
				return default(bool);
			}

			// Token: 0x0400A0C4 RID: 41156
			[Token(Token = "0x400A0C4")]
			[FieldOffset(Offset = "0x10")]
			public uint signID;
		}

		// Token: 0x02001BBE RID: 7102
		[Token(Token = "0x2001BBE")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FAC04", Offset = "0x10FAC04")]
		private sealed class <>c__DisplayClass26_0
		{
			// Token: 0x06009984 RID: 39300 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009984")]
			[Address(RVA = "0x19F6678", Offset = "0x19F6678", VA = "0x7BBC1F6678")]
			public <>c__DisplayClass26_0()
			{
			}

			// Token: 0x06009985 RID: 39301 RVA: 0x00028680 File Offset: 0x00026880
			[Token(Token = "0x6009985")]
			[Address(RVA = "0x19F7200", Offset = "0x19F7200", VA = "0x7BBC1F7200")]
			internal bool <DelayShowReward>b__0(AttendanceItem award)
			{
				return default(bool);
			}

			// Token: 0x0400A0C5 RID: 41157
			[Token(Token = "0x400A0C5")]
			[FieldOffset(Offset = "0x10")]
			public uint signID;
		}
	}
}
