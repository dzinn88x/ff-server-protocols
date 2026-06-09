using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020012A6 RID: 4774
	[Token(Token = "0x20012A6")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EB040", Offset = "0x10EB040")]
	public class PreviewStoryCgShowUIComp : UIBaseController
	{
		// Token: 0x06004AC5 RID: 19141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AC5")]
		[Address(RVA = "0x174BDF4", Offset = "0x174BDF4", VA = "0x7BBBF4BDF4")]
		public void SetStoryCGInstance(PreviewStoryCgComp ins)
		{
		}

		// Token: 0x06004AC6 RID: 19142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AC6")]
		[Address(RVA = "0x174BDFC", Offset = "0x174BDFC", VA = "0x7BBBF4BDFC")]
		public void InitShowUI(bool isHas)
		{
		}

		// Token: 0x06004AC7 RID: 19143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AC7")]
		[Address(RVA = "0x174C3B4", Offset = "0x174C3B4", VA = "0x7BBBF4C3B4")]
		public void PlaySubtitle(string subtitleStr)
		{
		}

		// Token: 0x06004AC8 RID: 19144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AC8")]
		[Address(RVA = "0x174C55C", Offset = "0x174C55C", VA = "0x7BBBF4C55C")]
		public void StopSubtitle()
		{
		}

		// Token: 0x06004AC9 RID: 19145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AC9")]
		[Address(RVA = "0x174C714", Offset = "0x174C714", VA = "0x7BBBF4C714")]
		public void ShowContinueLabel()
		{
		}

		// Token: 0x06004ACA RID: 19146 RVA: 0x00016848 File Offset: 0x00014A48
		[Token(Token = "0x6004ACA")]
		[Address(RVA = "0x174CC50", Offset = "0x174CC50", VA = "0x7BBBF4CC50")]
		protected bool CheckItemListIsBuy(List<uint> itemlist)
		{
			return default(bool);
		}

		// Token: 0x06004ACB RID: 19147 RVA: 0x00016860 File Offset: 0x00014A60
		[Token(Token = "0x6004ACB")]
		[Address(RVA = "0x174CD18", Offset = "0x174CD18", VA = "0x7BBBF4CD18")]
		protected bool CheckItemIsBuy(uint itemid)
		{
			return default(bool);
		}

		// Token: 0x06004ACC RID: 19148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004ACC")]
		[Address(RVA = "0x174CE2C", Offset = "0x174CE2C", VA = "0x7BBBF4CE2C", Slot = "9")]
		protected override void Awake()
		{
		}

		// Token: 0x06004ACD RID: 19149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004ACD")]
		[Address(RVA = "0x174D034", Offset = "0x174D034", VA = "0x7BBBF4D034")]
		private void Set3DModelVisiable(bool b)
		{
		}

		// Token: 0x06004ACE RID: 19150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004ACE")]
		[Address(RVA = "0x174D0E0", Offset = "0x174D0E0", VA = "0x7BBBF4D0E0")]
		private void OnbtnShare()
		{
		}

		// Token: 0x06004ACF RID: 19151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004ACF")]
		[Address(RVA = "0x174D24C", Offset = "0x174D24C", VA = "0x7BBBF4D24C", Slot = "23")]
		public override void BeforeScreenshot()
		{
		}

		// Token: 0x06004AD0 RID: 19152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AD0")]
		[Address(RVA = "0x174D3D4", Offset = "0x174D3D4", VA = "0x7BBBF4D3D4", Slot = "24")]
		public override void AfterScreenshot()
		{
		}

		// Token: 0x06004AD1 RID: 19153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AD1")]
		[Address(RVA = "0x174D1D8", Offset = "0x174D1D8", VA = "0x7BBBF4D1D8")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x113DD44", Offset = "0x113DD44")]
		private IEnumerator SetSharePreviewPos()
		{
			return null;
		}

		// Token: 0x06004AD2 RID: 19154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AD2")]
		[Address(RVA = "0x174D588", Offset = "0x174D588", VA = "0x7BBBF4D588")]
		private void OnbtnReplay()
		{
		}

		// Token: 0x06004AD3 RID: 19155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AD3")]
		[Address(RVA = "0x174D620", Offset = "0x174D620", VA = "0x7BBBF4D620")]
		private void ClearStoryCG()
		{
		}

		// Token: 0x06004AD4 RID: 19156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AD4")]
		[Address(RVA = "0x174D6B8", Offset = "0x174D6B8", VA = "0x7BBBF4D6B8")]
		private void OnbtnFunc()
		{
		}

		// Token: 0x06004AD5 RID: 19157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AD5")]
		[Address(RVA = "0x174D800", Offset = "0x174D800", VA = "0x7BBBF4D800")]
		public PreviewStoryCgShowUIComp()
		{
		}

		// Token: 0x04007305 RID: 29445
		[Token(Token = "0x4007305")]
		[FieldOffset(Offset = "0x58")]
		private PreviewStoryCgComp m_StoryCgInstance;

		// Token: 0x04007306 RID: 29446
		[Token(Token = "0x4007306")]
		[FieldOffset(Offset = "0x60")]
		public UIButton m_Sharebtn;

		// Token: 0x04007307 RID: 29447
		[Token(Token = "0x4007307")]
		[FieldOffset(Offset = "0x68")]
		public UIButton m_Replaybtn;

		// Token: 0x04007308 RID: 29448
		[Token(Token = "0x4007308")]
		[FieldOffset(Offset = "0x70")]
		public UIButton m_Funcbtn;

		// Token: 0x04007309 RID: 29449
		[Token(Token = "0x4007309")]
		[FieldOffset(Offset = "0x78")]
		public UITexture m_BgTex;

		// Token: 0x0400730A RID: 29450
		[Token(Token = "0x400730A")]
		[FieldOffset(Offset = "0x80")]
		public UISprite m_FreefireLogo;

		// Token: 0x0400730B RID: 29451
		[Token(Token = "0x400730B")]
		[FieldOffset(Offset = "0x88")]
		public UILabel m_FunTxt;

		// Token: 0x0400730C RID: 29452
		[Token(Token = "0x400730C")]
		[FieldOffset(Offset = "0x90")]
		private bool m_isLevelup;

		// Token: 0x0400730D RID: 29453
		[Token(Token = "0x400730D")]
		[FieldOffset(Offset = "0x98")]
		public GameObject Eppanel;

		// Token: 0x0400730E RID: 29454
		[Token(Token = "0x400730E")]
		[FieldOffset(Offset = "0xA0")]
		public GameObject MallPanel;

		// Token: 0x0400730F RID: 29455
		[Token(Token = "0x400730F")]
		[FieldOffset(Offset = "0xA8")]
		public GameObject GachaPanel;

		// Token: 0x04007310 RID: 29456
		[Token(Token = "0x4007310")]
		[FieldOffset(Offset = "0xB0")]
		public UILabel Subtitle;

		// Token: 0x04007311 RID: 29457
		[Token(Token = "0x4007311")]
		[FieldOffset(Offset = "0xB8")]
		public UILabel ContinueLabel;

		// Token: 0x020012A7 RID: 4775
		[Token(Token = "0x20012A7")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EB078", Offset = "0x10EB078")]
		private sealed class <SetSharePreviewPos>d__25 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06004AD6 RID: 19158 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004AD6")]
			[Address(RVA = "0x174D55C", Offset = "0x174D55C", VA = "0x7BBBF4D55C")]
			[DebuggerHidden]
			public <SetSharePreviewPos>d__25(int <>1__state)
			{
			}

			// Token: 0x06004AD7 RID: 19159 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004AD7")]
			[Address(RVA = "0x174D808", Offset = "0x174D808", VA = "0x7BBBF4D808", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06004AD8 RID: 19160 RVA: 0x00016878 File Offset: 0x00014A78
			[Token(Token = "0x6004AD8")]
			[Address(RVA = "0x174D80C", Offset = "0x174D80C", VA = "0x7BBBF4D80C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000844 RID: 2116
			// (get) Token: 0x06004AD9 RID: 19161 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000844")]
			private object Current
			{
				[Token(Token = "0x6004AD9")]
				[Address(RVA = "0x174DA50", Offset = "0x174DA50", VA = "0x7BBBF4DA50", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06004ADA RID: 19162 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004ADA")]
			[Address(RVA = "0x174DA58", Offset = "0x174DA58", VA = "0x7BBBF4DA58", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000845 RID: 2117
			// (get) Token: 0x06004ADB RID: 19163 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000845")]
			private object Current
			{
				[Token(Token = "0x6004ADB")]
				[Address(RVA = "0x174DAC0", Offset = "0x174DAC0", VA = "0x7BBBF4DAC0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04007312 RID: 29458
			[Token(Token = "0x4007312")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04007313 RID: 29459
			[Token(Token = "0x4007313")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04007314 RID: 29460
			[Token(Token = "0x4007314")]
			[FieldOffset(Offset = "0x20")]
			public PreviewStoryCgShowUIComp <>4__this;
		}
	}
}
