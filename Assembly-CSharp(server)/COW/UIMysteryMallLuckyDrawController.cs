using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020015AB RID: 5547
	[Token(Token = "0x20015AB")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EF094", Offset = "0x10EF094")]
	internal class UIMysteryMallLuckyDrawController : UINaviPopController, IUIModelDataChangeObserver
	{
		// Token: 0x060061C8 RID: 25032 RVA: 0x0001C200 File Offset: 0x0001A400
		[Token(Token = "0x60061C8")]
		[Address(RVA = "0x14D4694", Offset = "0x14D4694", VA = "0x7BBBCD4694")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060061C9 RID: 25033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061C9")]
		[Address(RVA = "0x14D46E4", Offset = "0x14D46E4", VA = "0x7BBBCD46E4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060061CA RID: 25034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061CA")]
		[Address(RVA = "0x14D4C18", Offset = "0x14D4C18", VA = "0x7BBBCD4C18", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060061CB RID: 25035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061CB")]
		[Address(RVA = "0x14D4CA8", Offset = "0x14D4CA8", VA = "0x7BBBCD4CA8")]
		private void SetLabelColor(UILabel label, Color topColor, Color bottomColor)
		{
		}

		// Token: 0x060061CC RID: 25036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061CC")]
		[Address(RVA = "0x14D4D6C", Offset = "0x14D4D6C", VA = "0x7BBBCD4D6C")]
		private void RefreshView()
		{
		}

		// Token: 0x060061CD RID: 25037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061CD")]
		[Address(RVA = "0x14D5184", Offset = "0x14D5184", VA = "0x7BBBCD5184")]
		private void ShowDrawingVFX()
		{
		}

		// Token: 0x060061CE RID: 25038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061CE")]
		[Address(RVA = "0x14D5350", Offset = "0x14D5350", VA = "0x7BBBCD5350")]
		private void OnBtnGetLuckClick()
		{
		}

		// Token: 0x060061CF RID: 25039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061CF")]
		[Address(RVA = "0x14D54F0", Offset = "0x14D54F0", VA = "0x7BBBCD54F0")]
		private void OnBtnGoMysteryClick()
		{
		}

		// Token: 0x060061D0 RID: 25040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60061D0")]
		[Address(RVA = "0x14D5110", Offset = "0x14D5110", VA = "0x7BBBCD5110")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x113FDE8", Offset = "0x113FDE8")]
		private IEnumerator StopDrawCoroutine()
		{
			return null;
		}

		// Token: 0x060061D1 RID: 25041 RVA: 0x0001C218 File Offset: 0x0001A418
		[Token(Token = "0x60061D1")]
		[Address(RVA = "0x14D5814", Offset = "0x14D5814", VA = "0x7BBBCD5814", Slot = "41")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x060061D2 RID: 25042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061D2")]
		[Address(RVA = "0x14D5858", Offset = "0x14D5858", VA = "0x7BBBCD5858", Slot = "40")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x060061D3 RID: 25043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061D3")]
		[Address(RVA = "0x14D58D0", Offset = "0x14D58D0", VA = "0x7BBBCD58D0")]
		public UIMysteryMallLuckyDrawController()
		{
		}

		// Token: 0x0400816F RID: 33135
		[Token(Token = "0x400816F")]
		[FieldOffset(Offset = "0xB8")]
		private UIMysteryMallLuckyDrawView m_View;

		// Token: 0x04008170 RID: 33136
		[Token(Token = "0x4008170")]
		[FieldOffset(Offset = "0xC0")]
		private UIModelMysteryMall m_ModelMall;

		// Token: 0x04008171 RID: 33137
		[Token(Token = "0x4008171")]
		[FieldOffset(Offset = "0xC8")]
		private bool m_IsDrawing;

		// Token: 0x020015AC RID: 5548
		[Token(Token = "0x20015AC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EF0CC", Offset = "0x10EF0CC")]
		private sealed class <StopDrawCoroutine>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x060061D4 RID: 25044 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60061D4")]
			[Address(RVA = "0x14D57E8", Offset = "0x14D57E8", VA = "0x7BBBCD57E8")]
			[DebuggerHidden]
			public <StopDrawCoroutine>d__11(int <>1__state)
			{
			}

			// Token: 0x060061D5 RID: 25045 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60061D5")]
			[Address(RVA = "0x14D58E0", Offset = "0x14D58E0", VA = "0x7BBBCD58E0", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x060061D6 RID: 25046 RVA: 0x0001C230 File Offset: 0x0001A430
			[Token(Token = "0x60061D6")]
			[Address(RVA = "0x14D58E4", Offset = "0x14D58E4", VA = "0x7BBBCD58E4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x170008C4 RID: 2244
			// (get) Token: 0x060061D7 RID: 25047 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170008C4")]
			private object Current
			{
				[Token(Token = "0x60061D7")]
				[Address(RVA = "0x14D5B64", Offset = "0x14D5B64", VA = "0x7BBBCD5B64", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x060061D8 RID: 25048 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60061D8")]
			[Address(RVA = "0x14D5B6C", Offset = "0x14D5B6C", VA = "0x7BBBCD5B6C", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x170008C5 RID: 2245
			// (get) Token: 0x060061D9 RID: 25049 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170008C5")]
			private object Current
			{
				[Token(Token = "0x60061D9")]
				[Address(RVA = "0x14D5BD4", Offset = "0x14D5BD4", VA = "0x7BBBCD5BD4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04008172 RID: 33138
			[Token(Token = "0x4008172")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04008173 RID: 33139
			[Token(Token = "0x4008173")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04008174 RID: 33140
			[Token(Token = "0x4008174")]
			[FieldOffset(Offset = "0x20")]
			public UIMysteryMallLuckyDrawController <>4__this;
		}
	}
}
