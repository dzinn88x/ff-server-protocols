using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001359 RID: 4953
	[Token(Token = "0x2001359")]
	internal class UIFFWSGuessController : UINaviPopController, IUIModelDataChangeObserver
	{
		// Token: 0x06004EBB RID: 20155 RVA: 0x000180A8 File Offset: 0x000162A8
		[Token(Token = "0x6004EBB")]
		[Address(RVA = "0x2274E28", Offset = "0x2274E28", VA = "0x7BBCA74E28")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06004EBC RID: 20156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EBC")]
		[Address(RVA = "0x2274E78", Offset = "0x2274E78", VA = "0x7BBCA74E78", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06004EBD RID: 20157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EBD")]
		[Address(RVA = "0x22756B8", Offset = "0x22756B8", VA = "0x7BBCA756B8", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x06004EBE RID: 20158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EBE")]
		[Address(RVA = "0x22758D8", Offset = "0x22758D8", VA = "0x7BBCA758D8", Slot = "29")]
		public override void OnNavigationClosed()
		{
		}

		// Token: 0x06004EBF RID: 20159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EBF")]
		[Address(RVA = "0x22758E0", Offset = "0x22758E0", VA = "0x7BBCA758E0", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x06004EC0 RID: 20160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EC0")]
		[Address(RVA = "0x2275A30", Offset = "0x2275A30", VA = "0x7BBCA75A30", Slot = "28")]
		public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
		{
		}

		// Token: 0x06004EC1 RID: 20161 RVA: 0x000180C0 File Offset: 0x000162C0
		[Token(Token = "0x6004EC1")]
		[Address(RVA = "0x2275B0C", Offset = "0x2275B0C", VA = "0x7BBCA75B0C", Slot = "35")]
		public override EFrontendBGMType GetBGMType()
		{
			return EFrontendBGMType.NONE;
		}

		// Token: 0x06004EC2 RID: 20162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EC2")]
		[Address(RVA = "0x2275B14", Offset = "0x2275B14", VA = "0x7BBCA75B14", Slot = "40")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06004EC3 RID: 20163 RVA: 0x000180D8 File Offset: 0x000162D8
		[Token(Token = "0x6004EC3")]
		[Address(RVA = "0x2276E40", Offset = "0x2276E40", VA = "0x7BBCA76E40", Slot = "41")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06004EC4 RID: 20164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EC4")]
		[Address(RVA = "0x2276EA4", Offset = "0x2276EA4", VA = "0x7BBCA76EA4")]
		private void RefreshRoundGrid()
		{
		}

		// Token: 0x06004EC5 RID: 20165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EC5")]
		[Address(RVA = "0x2277264", Offset = "0x2277264", VA = "0x7BBCA77264")]
		private void RefreshTeamGrid()
		{
		}

		// Token: 0x06004EC6 RID: 20166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EC6")]
		[Address(RVA = "0x227774C", Offset = "0x227774C", VA = "0x7BBCA7774C")]
		private void RefreshGuessTeams()
		{
		}

		// Token: 0x06004EC7 RID: 20167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EC7")]
		[Address(RVA = "0x22763F0", Offset = "0x22763F0", VA = "0x7BBCA763F0")]
		private void PlayVfxWin()
		{
		}

		// Token: 0x06004EC8 RID: 20168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EC8")]
		[Address(RVA = "0x2277BC4", Offset = "0x2277BC4", VA = "0x7BBCA77BC4")]
		private void PlayVfxBlink()
		{
		}

		// Token: 0x06004EC9 RID: 20169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EC9")]
		[Address(RVA = "0x22761D0", Offset = "0x22761D0", VA = "0x7BBCA761D0")]
		private void PlayVfxChosenTeam()
		{
		}

		// Token: 0x06004ECA RID: 20170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004ECA")]
		[Address(RVA = "0x2277B50", Offset = "0x2277B50", VA = "0x7BBCA77B50")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x113DED8", Offset = "0x113DED8")]
		private IEnumerator PlayTeamPointsTween()
		{
			return null;
		}

		// Token: 0x06004ECB RID: 20171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004ECB")]
		[Address(RVA = "0x2275404", Offset = "0x2275404", VA = "0x7BBCA75404")]
		private void CheckAndShowTutorialOnFirstEntering()
		{
		}

		// Token: 0x06004ECC RID: 20172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004ECC")]
		[Address(RVA = "0x2277F20", Offset = "0x2277F20", VA = "0x7BBCA77F20")]
		private void RefreshGuessPoints()
		{
		}

		// Token: 0x06004ECD RID: 20173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004ECD")]
		[Address(RVA = "0x227812C", Offset = "0x227812C", VA = "0x7BBCA7812C")]
		private void RefreshCountDown()
		{
		}

		// Token: 0x06004ECE RID: 20174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004ECE")]
		[Address(RVA = "0x2276B98", Offset = "0x2276B98", VA = "0x7BBCA76B98")]
		private void RefreshGuessAward()
		{
		}

		// Token: 0x06004ECF RID: 20175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004ECF")]
		[Address(RVA = "0x2278418", Offset = "0x2278418", VA = "0x7BBCA78418")]
		private void RefreshGuessBtn()
		{
		}

		// Token: 0x06004ED0 RID: 20176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004ED0")]
		[Address(RVA = "0x2276CE4", Offset = "0x2276CE4", VA = "0x7BBCA76CE4")]
		private void RefreshTokenView()
		{
		}

		// Token: 0x06004ED1 RID: 20177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004ED1")]
		[Address(RVA = "0x22760F8", Offset = "0x22760F8", VA = "0x7BBCA760F8")]
		private void RefreshView()
		{
		}

		// Token: 0x06004ED2 RID: 20178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004ED2")]
		[Address(RVA = "0x2278A10", Offset = "0x2278A10", VA = "0x7BBCA78A10")]
		private void OnChoosingRound(params object[] data)
		{
		}

		// Token: 0x06004ED3 RID: 20179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004ED3")]
		[Address(RVA = "0x2278AC4", Offset = "0x2278AC4", VA = "0x7BBCA78AC4")]
		private void OnChoosingTeam(params object[] data)
		{
		}

		// Token: 0x06004ED4 RID: 20180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004ED4")]
		[Address(RVA = "0x2278B50", Offset = "0x2278B50", VA = "0x7BBCA78B50")]
		private void OnClickGuess()
		{
		}

		// Token: 0x06004ED5 RID: 20181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004ED5")]
		[Address(RVA = "0x2279010", Offset = "0x2279010", VA = "0x7BBCA79010")]
		private void OnClickGotoLive()
		{
		}

		// Token: 0x06004ED6 RID: 20182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004ED6")]
		[Address(RVA = "0x2279150", Offset = "0x2279150", VA = "0x7BBCA79150")]
		private void OnClickGotoExchange()
		{
		}

		// Token: 0x06004ED7 RID: 20183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004ED7")]
		[Address(RVA = "0x2279290", Offset = "0x2279290", VA = "0x7BBCA79290")]
		private void OnClickAward()
		{
		}

		// Token: 0x06004ED8 RID: 20184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004ED8")]
		[Address(RVA = "0x227966C", Offset = "0x227966C", VA = "0x7BBCA7966C")]
		private void OnBtnRuleClick()
		{
		}

		// Token: 0x06004ED9 RID: 20185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004ED9")]
		[Address(RVA = "0x2279828", Offset = "0x2279828", VA = "0x7BBCA79828")]
		private void OnBtnFirstEnterTutorialClick()
		{
		}

		// Token: 0x06004EDA RID: 20186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EDA")]
		[Address(RVA = "0x22798C4", Offset = "0x22798C4", VA = "0x7BBCA798C4")]
		private void HideFirstEnterTutorial()
		{
		}

		// Token: 0x06004EDB RID: 20187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EDB")]
		[Address(RVA = "0x2279908", Offset = "0x2279908", VA = "0x7BBCA79908")]
		private void OnBtnTokenClick()
		{
		}

		// Token: 0x06004EDC RID: 20188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EDC")]
		[Address(RVA = "0x2279B48", Offset = "0x2279B48", VA = "0x7BBCA79B48")]
		public UIFFWSGuessController()
		{
		}

		// Token: 0x040075E9 RID: 30185
		[Token(Token = "0x40075E9")]
		[FieldOffset(Offset = "0xB8")]
		private UIFFWSGuessView m_View;

		// Token: 0x040075EA RID: 30186
		[Token(Token = "0x40075EA")]
		[FieldOffset(Offset = "0xC0")]
		private UIModelFFWS m_ModelFFWS;

		// Token: 0x040075EB RID: 30187
		[Token(Token = "0x40075EB")]
		[FieldOffset(Offset = "0xC8")]
		private uint m_ShowingRound;

		// Token: 0x040075EC RID: 30188
		[Token(Token = "0x40075EC")]
		[FieldOffset(Offset = "0xCC")]
		private uint m_PlayerChoosingTeam;

		// Token: 0x040075ED RID: 30189
		[Token(Token = "0x40075ED")]
		[FieldOffset(Offset = "0xD0")]
		private UICountDownController m_CountDownCtrl;

		// Token: 0x040075EE RID: 30190
		[Token(Token = "0x40075EE")]
		[FieldOffset(Offset = "0xD8")]
		private Coroutine m_CoroutineTeamPointsTween;

		// Token: 0x040075EF RID: 30191
		[Token(Token = "0x40075EF")]
		[FieldOffset(Offset = "0xE0")]
		private UICommonGuideController m_FirstEnterGuideCtrl;

		// Token: 0x040075F0 RID: 30192
		[Token(Token = "0x40075F0")]
		private const int INITAIL_ROUND = 0;

		// Token: 0x040075F1 RID: 30193
		[Token(Token = "0x40075F1")]
		[FieldOffset(Offset = "0xE8")]
		private int m_CountDownFontSize;

		// Token: 0x040075F2 RID: 30194
		[Token(Token = "0x40075F2")]
		[FieldOffset(Offset = "0xEC")]
		private uint m_DelayCallVfxFirstEnterRemind;

		// Token: 0x040075F3 RID: 30195
		[Token(Token = "0x40075F3")]
		[FieldOffset(Offset = "0xF0")]
		private string m_ChosenTeamIconUrlLeft;

		// Token: 0x040075F4 RID: 30196
		[Token(Token = "0x40075F4")]
		[FieldOffset(Offset = "0xF8")]
		private string m_ChosenTeamIconUrlRight;

		// Token: 0x0200135A RID: 4954
		[Token(Token = "0x200135A")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EB270", Offset = "0x10EB270")]
		private sealed class <PlayTeamPointsTween>d__27 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06004EDD RID: 20189 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004EDD")]
			[Address(RVA = "0x2277EF4", Offset = "0x2277EF4", VA = "0x7BBCA77EF4")]
			[DebuggerHidden]
			public <PlayTeamPointsTween>d__27(int <>1__state)
			{
			}

			// Token: 0x06004EDE RID: 20190 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004EDE")]
			[Address(RVA = "0x2279B58", Offset = "0x2279B58", VA = "0x7BBCA79B58", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06004EDF RID: 20191 RVA: 0x000180F0 File Offset: 0x000162F0
			[Token(Token = "0x6004EDF")]
			[Address(RVA = "0x2279BCC", Offset = "0x2279BCC", VA = "0x7BBCA79BCC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x06004EE0 RID: 20192 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004EE0")]
			[Address(RVA = "0x2279B74", Offset = "0x2279B74", VA = "0x7BBCA79B74")]
			private void <>m__Finally1()
			{
			}

			// Token: 0x17000866 RID: 2150
			// (get) Token: 0x06004EE1 RID: 20193 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000866")]
			private object Current
			{
				[Token(Token = "0x6004EE1")]
				[Address(RVA = "0x2279F38", Offset = "0x2279F38", VA = "0x7BBCA79F38", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06004EE2 RID: 20194 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004EE2")]
			[Address(RVA = "0x2279F40", Offset = "0x2279F40", VA = "0x7BBCA79F40", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000867 RID: 2151
			// (get) Token: 0x06004EE3 RID: 20195 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000867")]
			private object Current
			{
				[Token(Token = "0x6004EE3")]
				[Address(RVA = "0x2279FA8", Offset = "0x2279FA8", VA = "0x7BBCA79FA8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x040075F5 RID: 30197
			[Token(Token = "0x40075F5")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x040075F6 RID: 30198
			[Token(Token = "0x40075F6")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x040075F7 RID: 30199
			[Token(Token = "0x40075F7")]
			[FieldOffset(Offset = "0x20")]
			public UIFFWSGuessController <>4__this;

			// Token: 0x040075F8 RID: 30200
			[Token(Token = "0x40075F8")]
			[FieldOffset(Offset = "0x28")]
			private List<Transform>.Enumerator <>7__wrap1;
		}
	}
}
