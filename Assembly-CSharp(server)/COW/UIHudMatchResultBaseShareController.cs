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
	// Token: 0x0200190E RID: 6414
	[Token(Token = "0x200190E")]
	internal class UIHudMatchResultBaseShareController : UIBaseController, IUIModelDataChangeObserver
	{
		// Token: 0x060080ED RID: 33005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080ED")]
		[Address(RVA = "0x15BFE6C", Offset = "0x15BFE6C", VA = "0x7BBBDBFE6C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060080EE RID: 33006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080EE")]
		[Address(RVA = "0x15CC74C", Offset = "0x15CC74C", VA = "0x7BBBDCC74C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060080EF RID: 33007 RVA: 0x000232C8 File Offset: 0x000214C8
		[Token(Token = "0x60080EF")]
		[Address(RVA = "0x15CC86C", Offset = "0x15CC86C", VA = "0x7BBBDCC86C", Slot = "29")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x060080F0 RID: 33008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080F0")]
		[Address(RVA = "0x15CC8BC", Offset = "0x15CC8BC", VA = "0x7BBBDCC8BC", Slot = "28")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x060080F1 RID: 33009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080F1")]
		[Address(RVA = "0x15C7830", Offset = "0x15C7830", VA = "0x7BBBDC7830", Slot = "30")]
		protected virtual void OnMatchStatsChange(MatchStats stats, MatchIncome income)
		{
		}

		// Token: 0x060080F2 RID: 33010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080F2")]
		[Address(RVA = "0x15BFFF0", Offset = "0x15BFFF0", VA = "0x7BBBDBFFF0")]
		protected void InitScreenShotShare(UIButton btn)
		{
		}

		// Token: 0x060080F3 RID: 33011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080F3")]
		[Address(RVA = "0x15CCABC", Offset = "0x15CCABC", VA = "0x7BBBDCCABC")]
		private void RegisterScreenShotShareEvetns()
		{
		}

		// Token: 0x060080F4 RID: 33012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080F4")]
		[Address(RVA = "0x15CC78C", Offset = "0x15CC78C", VA = "0x7BBBDCC78C")]
		private void UnregisterScreenShotShareEvetns()
		{
		}

		// Token: 0x060080F5 RID: 33013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080F5")]
		[Address(RVA = "0x15C6ED8", Offset = "0x15C6ED8", VA = "0x7BBBDC6ED8")]
		protected void DisableCameraFlareLayer()
		{
		}

		// Token: 0x060080F6 RID: 33014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080F6")]
		[Address(RVA = "0x15CCB9C", Offset = "0x15CCB9C", VA = "0x7BBBDCCB9C", Slot = "31")]
		protected virtual void OnShareBtnClick()
		{
		}

		// Token: 0x060080F7 RID: 33015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080F7")]
		[Address(RVA = "0x15CCDA4", Offset = "0x15CCDA4", VA = "0x7BBBDCCDA4")]
		private void MakeShareImage()
		{
		}

		// Token: 0x060080F8 RID: 33016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60080F8")]
		[Address(RVA = "0x15CCFAC", Offset = "0x15CCFAC", VA = "0x7BBBDCCFAC", Slot = "32")]
		protected virtual UIMatchResultScreenshotController.MatchResultScreenshotData CreateScreenShotData()
		{
			return null;
		}

		// Token: 0x060080F9 RID: 33017 RVA: 0x000232E0 File Offset: 0x000214E0
		[Token(Token = "0x60080F9")]
		[Address(RVA = "0x15CD1A4", Offset = "0x15CD1A4", VA = "0x7BBBDCD1A4", Slot = "33")]
		protected virtual bool HasDefeater(MatchStats stats)
		{
			return default(bool);
		}

		// Token: 0x060080FA RID: 33018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080FA")]
		[Address(RVA = "0x15CD234", Offset = "0x15CD234", VA = "0x7BBBDCD234")]
		private void OnScreenshotResponse(params object[] param)
		{
		}

		// Token: 0x060080FB RID: 33019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080FB")]
		[Address(RVA = "0x15CCEC0", Offset = "0x15CCEC0", VA = "0x7BBBDCCEC0")]
		private void ShowSharePanel()
		{
		}

		// Token: 0x060080FC RID: 33020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080FC")]
		[Address(RVA = "0x15C0148", Offset = "0x15C0148", VA = "0x7BBBDC0148")]
		protected void InitReturnButton(UIButton btn)
		{
		}

		// Token: 0x060080FD RID: 33021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080FD")]
		[Address(RVA = "0x15CD33C", Offset = "0x15CD33C", VA = "0x7BBBDCD33C")]
		protected void InitReturnButtonToCommonMatchResult(UIButton btn)
		{
		}

		// Token: 0x060080FE RID: 33022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080FE")]
		[Address(RVA = "0x15C8570", Offset = "0x15C8570", VA = "0x7BBBDC8570", Slot = "34")]
		protected virtual void ReturnToLobby()
		{
		}

		// Token: 0x060080FF RID: 33023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080FF")]
		[Address(RVA = "0x15C0598", Offset = "0x15C0598", VA = "0x7BBBDC0598")]
		protected void StartAutoReturnToLobby(float secs)
		{
		}

		// Token: 0x06008100 RID: 33024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008100")]
		[Address(RVA = "0x15CD494", Offset = "0x15CD494", VA = "0x7BBBDCD494")]
		protected void StartAutoReturnToCommonMatchResult(float secs)
		{
		}

		// Token: 0x06008101 RID: 33025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008101")]
		[Address(RVA = "0x15CCD3C", Offset = "0x15CCD3C", VA = "0x7BBBDCCD3C")]
		protected void StopAutoReturnToLobby()
		{
		}

		// Token: 0x06008102 RID: 33026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008102")]
		[Address(RVA = "0x15CCD70", Offset = "0x15CCD70", VA = "0x7BBBDCCD70")]
		protected void StopAutoReturnToCommonMatchResult()
		{
		}

		// Token: 0x06008103 RID: 33027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008103")]
		[Address(RVA = "0x15CD3FC", Offset = "0x15CD3FC", VA = "0x7BBBDCD3FC")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1143108", Offset = "0x1143108")]
		protected IEnumerator WaitAndReturnToLobby(float secs)
		{
			return null;
		}

		// Token: 0x06008104 RID: 33028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008104")]
		[Address(RVA = "0x15CD4C8", Offset = "0x15CD4C8", VA = "0x7BBBDCD4C8")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x114316C", Offset = "0x114316C")]
		protected IEnumerator WaitAndReturnCommonMatchResult(float secs)
		{
			return null;
		}

		// Token: 0x06008105 RID: 33029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008105")]
		[Address(RVA = "0x15CD5B8", Offset = "0x15CD5B8", VA = "0x7BBBDCD5B8", Slot = "35")]
		protected virtual void ShowCommonMatchResult()
		{
		}

		// Token: 0x06008106 RID: 33030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008106")]
		[Address(RVA = "0x15C2048", Offset = "0x15C2048", VA = "0x7BBBDC2048")]
		public UIHudMatchResultBaseShareController()
		{
		}

		// Token: 0x040092E2 RID: 37602
		[Token(Token = "0x40092E2")]
		[FieldOffset(Offset = "0x58")]
		protected UIModelMatch m_ModelMatch;

		// Token: 0x040092E3 RID: 37603
		[Token(Token = "0x40092E3")]
		[FieldOffset(Offset = "0x60")]
		protected MatchStats m_MatchStats;

		// Token: 0x040092E4 RID: 37604
		[Token(Token = "0x40092E4")]
		[FieldOffset(Offset = "0x68")]
		protected MatchIncome m_MatchIncome;

		// Token: 0x040092E5 RID: 37605
		[Token(Token = "0x40092E5")]
		[FieldOffset(Offset = "0x70")]
		protected bool m_UseNewShare;

		// Token: 0x040092E6 RID: 37606
		[Token(Token = "0x40092E6")]
		[FieldOffset(Offset = "0x71")]
		protected bool m_ScreenshotShareInited;

		// Token: 0x040092E7 RID: 37607
		[Token(Token = "0x40092E7")]
		[FieldOffset(Offset = "0x78")]
		private string m_ScreenshotFilePath;

		// Token: 0x040092E8 RID: 37608
		[Token(Token = "0x40092E8")]
		[FieldOffset(Offset = "0x80")]
		private bool m_IsHaveShareFile;

		// Token: 0x040092E9 RID: 37609
		[Token(Token = "0x40092E9")]
		[FieldOffset(Offset = "0x88")]
		private UIMatchResultScreenshotController.MatchResultScreenshotData m_ScreenShotData;

		// Token: 0x040092EA RID: 37610
		[Token(Token = "0x40092EA")]
		[FieldOffset(Offset = "0x90")]
		private Coroutine m_AutoReturnToLobbyCor;

		// Token: 0x040092EB RID: 37611
		[Token(Token = "0x40092EB")]
		[FieldOffset(Offset = "0x98")]
		private Coroutine m_AutoReturnCommonMatchResultCor;

		// Token: 0x0200190F RID: 6415
		[Token(Token = "0x200190F")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F571C", Offset = "0x10F571C")]
		private sealed class <WaitAndReturnToLobby>d__32 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06008107 RID: 33031 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008107")]
			[Address(RVA = "0x15CD560", Offset = "0x15CD560", VA = "0x7BBBDCD560")]
			[DebuggerHidden]
			public <WaitAndReturnToLobby>d__32(int <>1__state)
			{
			}

			// Token: 0x06008108 RID: 33032 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008108")]
			[Address(RVA = "0x15CD830", Offset = "0x15CD830", VA = "0x7BBBDCD830", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06008109 RID: 33033 RVA: 0x000232F8 File Offset: 0x000214F8
			[Token(Token = "0x6008109")]
			[Address(RVA = "0x15CD834", Offset = "0x15CD834", VA = "0x7BBBDCD834", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x170009A5 RID: 2469
			// (get) Token: 0x0600810A RID: 33034 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170009A5")]
			private object Current
			{
				[Token(Token = "0x600810A")]
				[Address(RVA = "0x15CD8F8", Offset = "0x15CD8F8", VA = "0x7BBBDCD8F8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0600810B RID: 33035 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600810B")]
			[Address(RVA = "0x15CD900", Offset = "0x15CD900", VA = "0x7BBBDCD900", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x170009A6 RID: 2470
			// (get) Token: 0x0600810C RID: 33036 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170009A6")]
			private object Current
			{
				[Token(Token = "0x600810C")]
				[Address(RVA = "0x15CD968", Offset = "0x15CD968", VA = "0x7BBBDCD968", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x040092EC RID: 37612
			[Token(Token = "0x40092EC")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x040092ED RID: 37613
			[Token(Token = "0x40092ED")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x040092EE RID: 37614
			[Token(Token = "0x40092EE")]
			[FieldOffset(Offset = "0x20")]
			public float secs;

			// Token: 0x040092EF RID: 37615
			[Token(Token = "0x40092EF")]
			[FieldOffset(Offset = "0x28")]
			public UIHudMatchResultBaseShareController <>4__this;
		}

		// Token: 0x02001910 RID: 6416
		[Token(Token = "0x2001910")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F572C", Offset = "0x10F572C")]
		private sealed class <WaitAndReturnCommonMatchResult>d__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x0600810D RID: 33037 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600810D")]
			[Address(RVA = "0x15CD58C", Offset = "0x15CD58C", VA = "0x7BBBDCD58C")]
			[DebuggerHidden]
			public <WaitAndReturnCommonMatchResult>d__33(int <>1__state)
			{
			}

			// Token: 0x0600810E RID: 33038 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600810E")]
			[Address(RVA = "0x15CD6F0", Offset = "0x15CD6F0", VA = "0x7BBBDCD6F0", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x0600810F RID: 33039 RVA: 0x00023310 File Offset: 0x00021510
			[Token(Token = "0x600810F")]
			[Address(RVA = "0x15CD6F4", Offset = "0x15CD6F4", VA = "0x7BBBDCD6F4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x170009A7 RID: 2471
			// (get) Token: 0x06008110 RID: 33040 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170009A7")]
			private object Current
			{
				[Token(Token = "0x6008110")]
				[Address(RVA = "0x15CD7B8", Offset = "0x15CD7B8", VA = "0x7BBBDCD7B8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06008111 RID: 33041 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008111")]
			[Address(RVA = "0x15CD7C0", Offset = "0x15CD7C0", VA = "0x7BBBDCD7C0", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x170009A8 RID: 2472
			// (get) Token: 0x06008112 RID: 33042 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170009A8")]
			private object Current
			{
				[Token(Token = "0x6008112")]
				[Address(RVA = "0x15CD828", Offset = "0x15CD828", VA = "0x7BBBDCD828", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x040092F0 RID: 37616
			[Token(Token = "0x40092F0")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x040092F1 RID: 37617
			[Token(Token = "0x40092F1")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x040092F2 RID: 37618
			[Token(Token = "0x40092F2")]
			[FieldOffset(Offset = "0x20")]
			public float secs;

			// Token: 0x040092F3 RID: 37619
			[Token(Token = "0x40092F3")]
			[FieldOffset(Offset = "0x28")]
			public UIHudMatchResultBaseShareController <>4__this;
		}
	}
}
