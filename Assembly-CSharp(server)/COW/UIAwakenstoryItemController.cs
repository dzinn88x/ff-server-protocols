using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200143A RID: 5178
	[Token(Token = "0x200143A")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10ECAB8", Offset = "0x10ECAB8")]
	internal class UIAwakenstoryItemController : UIBaseController
	{
		// Token: 0x060055F7 RID: 22007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055F7")]
		[Address(RVA = "0x141D6B4", Offset = "0x141D6B4", VA = "0x7BBBC1D6B4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060055F8 RID: 22008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055F8")]
		[Address(RVA = "0x141D7A8", Offset = "0x141D7A8", VA = "0x7BBBC1D7A8", Slot = "19")]
		protected override void OnVisibilityChanged()
		{
		}

		// Token: 0x060055F9 RID: 22009 RVA: 0x00019998 File Offset: 0x00017B98
		[Token(Token = "0x60055F9")]
		[Address(RVA = "0x141D7EC", Offset = "0x141D7EC", VA = "0x7BBBC1D7EC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060055FA RID: 22010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055FA")]
		[Address(RVA = "0x141D83C", Offset = "0x141D83C", VA = "0x7BBBC1D83C")]
		public void SetContainer(UIPanel panel)
		{
		}

		// Token: 0x060055FB RID: 22011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055FB")]
		[Address(RVA = "0x141D87C", Offset = "0x141D87C", VA = "0x7BBBC1D87C")]
		public void SetCDNInfo(AvatarAwakenComicData comicData)
		{
		}

		// Token: 0x060055FC RID: 22012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055FC")]
		[Address(RVA = "0x141DAD8", Offset = "0x141DAD8", VA = "0x7BBBC1DAD8")]
		private void OnPlayButtonClick()
		{
		}

		// Token: 0x060055FD RID: 22013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055FD")]
		[Address(RVA = "0x141DB04", Offset = "0x141DB04", VA = "0x7BBBC1DB04")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x113EB1C", Offset = "0x113EB1C")]
		private IEnumerator StartShowComic()
		{
			return null;
		}

		// Token: 0x060055FE RID: 22014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055FE")]
		[Address(RVA = "0x141DA94", Offset = "0x141DA94", VA = "0x7BBBC1DA94")]
		private void SetCDN(UINetworkTextureExt cdn, string url)
		{
		}

		// Token: 0x060055FF RID: 22015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055FF")]
		[Address(RVA = "0x141DBA4", Offset = "0x141DBA4", VA = "0x7BBBC1DBA4")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x113EB80", Offset = "0x113EB80")]
		private IEnumerator PlayAndWaitingForAnimationOver(Animation animationCom, string animation)
		{
			return null;
		}

		// Token: 0x06005600 RID: 22016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005600")]
		[Address(RVA = "0x141DC68", Offset = "0x141DC68", VA = "0x7BBBC1DC68")]
		public UIAwakenstoryItemController()
		{
		}

		// Token: 0x04007AB5 RID: 31413
		[Token(Token = "0x4007AB5")]
		[FieldOffset(Offset = "0x58")]
		private AvatarAwakenComicData m_Data;

		// Token: 0x04007AB6 RID: 31414
		[Token(Token = "0x4007AB6")]
		[FieldOffset(Offset = "0x60")]
		private uint m_StoryId;

		// Token: 0x04007AB7 RID: 31415
		[Token(Token = "0x4007AB7")]
		[FieldOffset(Offset = "0x68")]
		private UIModelAvatarProfile m_Model;

		// Token: 0x04007AB8 RID: 31416
		[Token(Token = "0x4007AB8")]
		[FieldOffset(Offset = "0x70")]
		private UIAwakenStoryItemView m_View;

		// Token: 0x04007AB9 RID: 31417
		[Token(Token = "0x4007AB9")]
		[FieldOffset(Offset = "0x78")]
		private UIPanel m_Conatainer;

		// Token: 0x04007ABA RID: 31418
		[Token(Token = "0x4007ABA")]
		[FieldOffset(Offset = "0x80")]
		private int m_DefaultDepth;

		// Token: 0x0200143B RID: 5179
		[Token(Token = "0x200143B")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10ECAF0", Offset = "0x10ECAF0")]
		private sealed class <StartShowComic>d__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06005601 RID: 22017 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005601")]
			[Address(RVA = "0x141DB78", Offset = "0x141DB78", VA = "0x7BBBC1DB78")]
			[DebuggerHidden]
			public <StartShowComic>d__12(int <>1__state)
			{
			}

			// Token: 0x06005602 RID: 22018 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005602")]
			[Address(RVA = "0x141DE74", Offset = "0x141DE74", VA = "0x7BBBC1DE74", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06005603 RID: 22019 RVA: 0x000199B0 File Offset: 0x00017BB0
			[Token(Token = "0x6005603")]
			[Address(RVA = "0x141DE78", Offset = "0x141DE78", VA = "0x7BBBC1DE78", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000882 RID: 2178
			// (get) Token: 0x06005604 RID: 22020 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000882")]
			private object Current
			{
				[Token(Token = "0x6005604")]
				[Address(RVA = "0x141E090", Offset = "0x141E090", VA = "0x7BBBC1E090", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06005605 RID: 22021 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005605")]
			[Address(RVA = "0x141E098", Offset = "0x141E098", VA = "0x7BBBC1E098", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000883 RID: 2179
			// (get) Token: 0x06005606 RID: 22022 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000883")]
			private object Current
			{
				[Token(Token = "0x6005606")]
				[Address(RVA = "0x141E100", Offset = "0x141E100", VA = "0x7BBBC1E100", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04007ABB RID: 31419
			[Token(Token = "0x4007ABB")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04007ABC RID: 31420
			[Token(Token = "0x4007ABC")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04007ABD RID: 31421
			[Token(Token = "0x4007ABD")]
			[FieldOffset(Offset = "0x20")]
			public UIAwakenstoryItemController <>4__this;
		}

		// Token: 0x0200143C RID: 5180
		[Token(Token = "0x200143C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10ECB00", Offset = "0x10ECB00")]
		private sealed class <PlayAndWaitingForAnimationOver>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06005607 RID: 22023 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005607")]
			[Address(RVA = "0x141DC3C", Offset = "0x141DC3C", VA = "0x7BBBC1DC3C")]
			[DebuggerHidden]
			public <PlayAndWaitingForAnimationOver>d__14(int <>1__state)
			{
			}

			// Token: 0x06005608 RID: 22024 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005608")]
			[Address(RVA = "0x141DC70", Offset = "0x141DC70", VA = "0x7BBBC1DC70", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06005609 RID: 22025 RVA: 0x000199C8 File Offset: 0x00017BC8
			[Token(Token = "0x6005609")]
			[Address(RVA = "0x141DC74", Offset = "0x141DC74", VA = "0x7BBBC1DC74", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000884 RID: 2180
			// (get) Token: 0x0600560A RID: 22026 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000884")]
			private object Current
			{
				[Token(Token = "0x600560A")]
				[Address(RVA = "0x141DDFC", Offset = "0x141DDFC", VA = "0x7BBBC1DDFC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0600560B RID: 22027 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600560B")]
			[Address(RVA = "0x141DE04", Offset = "0x141DE04", VA = "0x7BBBC1DE04", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000885 RID: 2181
			// (get) Token: 0x0600560C RID: 22028 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000885")]
			private object Current
			{
				[Token(Token = "0x600560C")]
				[Address(RVA = "0x141DE6C", Offset = "0x141DE6C", VA = "0x7BBBC1DE6C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04007ABE RID: 31422
			[Token(Token = "0x4007ABE")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04007ABF RID: 31423
			[Token(Token = "0x4007ABF")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04007AC0 RID: 31424
			[Token(Token = "0x4007AC0")]
			[FieldOffset(Offset = "0x20")]
			public Animation animationCom;

			// Token: 0x04007AC1 RID: 31425
			[Token(Token = "0x4007AC1")]
			[FieldOffset(Offset = "0x28")]
			public string animation;

			// Token: 0x04007AC2 RID: 31426
			[Token(Token = "0x4007AC2")]
			[FieldOffset(Offset = "0x30")]
			private float <aniamtionTime>5__2;
		}
	}
}
