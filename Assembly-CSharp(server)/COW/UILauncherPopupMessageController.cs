using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020019C8 RID: 6600
	[Token(Token = "0x20019C8")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F7084", Offset = "0x10F7084")]
	internal class UILauncherPopupMessageController : UIBaseController
	{
		// Token: 0x060087AD RID: 34733 RVA: 0x00024A08 File Offset: 0x00022C08
		[Token(Token = "0x60087AD")]
		[Address(RVA = "0x1E26CD8", Offset = "0x1E26CD8", VA = "0x7BBC626CD8")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060087AE RID: 34734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60087AE")]
		[Address(RVA = "0x1E26D40", Offset = "0x1E26D40", VA = "0x7BBC626D40", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060087AF RID: 34735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60087AF")]
		[Address(RVA = "0x1E27108", Offset = "0x1E27108", VA = "0x7BBC627108", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x060087B0 RID: 34736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60087B0")]
		[Address(RVA = "0x1E27130", Offset = "0x1E27130", VA = "0x7BBC627130", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060087B1 RID: 34737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60087B1")]
		[Address(RVA = "0x1E2717C", Offset = "0x1E2717C", VA = "0x7BBC62717C", Slot = "19")]
		protected override void OnVisibilityChanged()
		{
		}

		// Token: 0x060087B2 RID: 34738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60087B2")]
		[Address(RVA = "0x1E271F8", Offset = "0x1E271F8", VA = "0x7BBC6271F8")]
		public void ShowMessageBox(string info, UILauncherPopupMessageController.ELauncherMessageType mbType, [Optional] Action onOK, UILauncherPopupMessageController.EButtonStyle buttonStyle = UILauncherPopupMessageController.EButtonStyle.OK, [Optional] string[] urlList, [Optional] string patchNoteUrl, [Optional] Action onRetry, [Optional] string webViewUrl, [Optional] string bgUrl, [Optional] string maxUrl)
		{
		}

		// Token: 0x060087B3 RID: 34739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60087B3")]
		[Address(RVA = "0x1E2855C", Offset = "0x1E2855C", VA = "0x7BBC62855C")]
		private void OnPatchNoteBtnClick()
		{
		}

		// Token: 0x060087B4 RID: 34740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60087B4")]
		[Address(RVA = "0x1E28630", Offset = "0x1E28630", VA = "0x7BBC628630")]
		private void OnBtnOKClick()
		{
		}

		// Token: 0x060087B5 RID: 34741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60087B5")]
		[Address(RVA = "0x1E27304", Offset = "0x1E27304", VA = "0x7BBC627304")]
		private void UpdateView()
		{
		}

		// Token: 0x060087B6 RID: 34742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60087B6")]
		[Address(RVA = "0x1E28904", Offset = "0x1E28904", VA = "0x7BBC628904")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x114360C", Offset = "0x114360C")]
		private IEnumerator AutoScrollItem()
		{
			return null;
		}

		// Token: 0x060087B7 RID: 34743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60087B7")]
		[Address(RVA = "0x1E289A4", Offset = "0x1E289A4", VA = "0x7BBC6289A4")]
		private void OnAutoScrollAdItem()
		{
		}

		// Token: 0x060087B8 RID: 34744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60087B8")]
		[Address(RVA = "0x1E28AF0", Offset = "0x1E28AF0", VA = "0x7BBC628AF0", Slot = "21")]
		public override void Show()
		{
		}

		// Token: 0x060087B9 RID: 34745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60087B9")]
		[Address(RVA = "0x1E286A0", Offset = "0x1E286A0", VA = "0x7BBC6286A0")]
		private UILobbyDotController CreateDot()
		{
			return null;
		}

		// Token: 0x060087BA RID: 34746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60087BA")]
		[Address(RVA = "0x1E28C10", Offset = "0x1E28C10", VA = "0x7BBC628C10")]
		private void GetCenterItem(GameObject centeredObject)
		{
		}

		// Token: 0x060087BB RID: 34747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60087BB")]
		[Address(RVA = "0x1E28DE4", Offset = "0x1E28DE4", VA = "0x7BBC628DE4")]
		public UILauncherPopupMessageController()
		{
		}

		// Token: 0x0400962A RID: 38442
		[Token(Token = "0x400962A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private UILauncherPopupMessageView m_View;

		// Token: 0x0400962B RID: 38443
		[Token(Token = "0x400962B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private UILauncherPopupMessageController.EButtonStyle m_ButtonStyle;

		// Token: 0x0400962C RID: 38444
		[Token(Token = "0x400962C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private UILauncherPopupMessageController.ELauncherMessageType m_MessageType;

		// Token: 0x0400962D RID: 38445
		[Token(Token = "0x400962D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private string m_Info;

		// Token: 0x0400962E RID: 38446
		[Token(Token = "0x400962E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private string[] m_CDNUrlList;

		// Token: 0x0400962F RID: 38447
		[Token(Token = "0x400962F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private string m_PatchNoteUrl;

		// Token: 0x04009630 RID: 38448
		[Token(Token = "0x4009630")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private string m_WebViewUrl;

		// Token: 0x04009631 RID: 38449
		[Token(Token = "0x4009631")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private WebView m_WebView;

		// Token: 0x04009632 RID: 38450
		[Token(Token = "0x4009632")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private string m_BGUrl;

		// Token: 0x04009633 RID: 38451
		[Token(Token = "0x4009633")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool m_HasMaxHint;

		// Token: 0x04009634 RID: 38452
		[Token(Token = "0x4009634")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Action m_OnOK;

		// Token: 0x04009635 RID: 38453
		[Token(Token = "0x4009635")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Action m_OnRetry;

		// Token: 0x04009636 RID: 38454
		[Token(Token = "0x4009636")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private int m_selectedIndex;

		// Token: 0x04009637 RID: 38455
		[Token(Token = "0x4009637")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private List<UILobbyDotController> m_DotCtrls;

		// Token: 0x04009638 RID: 38456
		[Token(Token = "0x4009638")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private List<UINetworkTexture> m_NetworkTextures;

		// Token: 0x04009639 RID: 38457
		[Token(Token = "0x4009639")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private UICenterOnChild m_centerOnChild;

		// Token: 0x0400963A RID: 38458
		[Token(Token = "0x400963A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static string defaultCDN;

		// Token: 0x0400963B RID: 38459
		[Token(Token = "0x400963B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static string defaultBGCDN;

		// Token: 0x020019C9 RID: 6601
		[Token(Token = "0x20019C9")]
		public enum EButtonStyle
		{
			// Token: 0x0400963D RID: 38461
			[Token(Token = "0x400963D")]
			None,
			// Token: 0x0400963E RID: 38462
			[Token(Token = "0x400963E")]
			OK,
			// Token: 0x0400963F RID: 38463
			[Token(Token = "0x400963F")]
			Update
		}

		// Token: 0x020019CA RID: 6602
		[Token(Token = "0x20019CA")]
		public enum ELauncherMessageType
		{
			// Token: 0x04009641 RID: 38465
			[Token(Token = "0x4009641")]
			SystemError,
			// Token: 0x04009642 RID: 38466
			[Token(Token = "0x4009642")]
			Maintenance,
			// Token: 0x04009643 RID: 38467
			[Token(Token = "0x4009643")]
			HotUpdate,
			// Token: 0x04009644 RID: 38468
			[Token(Token = "0x4009644")]
			VersionUpdate,
			// Token: 0x04009645 RID: 38469
			[Token(Token = "0x4009645")]
			DownloadRetry
		}

		// Token: 0x020019CB RID: 6603
		[Token(Token = "0x20019CB")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F70BC", Offset = "0x10F70BC")]
		private sealed class <AutoScrollItem>d__29 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x060087BD RID: 34749 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60087BD")]
			[Address(RVA = "0x1E28978", Offset = "0x1E28978", VA = "0x7BBC628978")]
			[DebuggerHidden]
			public <AutoScrollItem>d__29(int <>1__state)
			{
			}

			// Token: 0x060087BE RID: 34750 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60087BE")]
			[Address(RVA = "0x1E28F18", Offset = "0x1E28F18", VA = "0x7BBC628F18", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x060087BF RID: 34751 RVA: 0x00024A20 File Offset: 0x00022C20
			[Token(Token = "0x60087BF")]
			[Address(RVA = "0x1E28F1C", Offset = "0x1E28F1C", VA = "0x7BBC628F1C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x170009B6 RID: 2486
			// (get) Token: 0x060087C0 RID: 34752 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170009B6")]
			private object Current
			{
				[Token(Token = "0x60087C0")]
				[Address(RVA = "0x1E29000", Offset = "0x1E29000", VA = "0x7BBC629000", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x060087C1 RID: 34753 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60087C1")]
			[Address(RVA = "0x1E29008", Offset = "0x1E29008", VA = "0x7BBC629008", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x170009B7 RID: 2487
			// (get) Token: 0x060087C2 RID: 34754 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170009B7")]
			private object Current
			{
				[Token(Token = "0x60087C2")]
				[Address(RVA = "0x1E29070", Offset = "0x1E29070", VA = "0x7BBC629070", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04009646 RID: 38470
			[Token(Token = "0x4009646")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04009647 RID: 38471
			[Token(Token = "0x4009647")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04009648 RID: 38472
			[Token(Token = "0x4009648")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public UILauncherPopupMessageController <>4__this;
		}
	}
}
