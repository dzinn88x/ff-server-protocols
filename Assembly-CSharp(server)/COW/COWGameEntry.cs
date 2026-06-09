using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace COW
{
	// Token: 0x020011AE RID: 4526
	[Token(Token = "0x20011AE")]
	public class COWGameEntry : MonoBehaviour
	{
		// Token: 0x17000824 RID: 2084
		// (get) Token: 0x06004665 RID: 18021 RVA: 0x000153F0 File Offset: 0x000135F0
		// (set) Token: 0x06004666 RID: 18022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000824")]
		public bool Paused
		{
			[Token(Token = "0x6004665")]
			[Address(RVA = "0x14E9318", Offset = "0x14E9318", VA = "0x7BBBCE9318")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113DA38", Offset = "0x113DA38")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004666")]
			[Address(RVA = "0x14E9320", Offset = "0x14E9320", VA = "0x7BBBCE9320")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113DA48", Offset = "0x113DA48")]
			set
			{
			}
		}

		// Token: 0x06004667 RID: 18023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004667")]
		[Address(RVA = "0x14E932C", Offset = "0x14E932C", VA = "0x7BBBCE932C")]
		private void Awake()
		{
		}

		// Token: 0x06004668 RID: 18024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004668")]
		[Address(RVA = "0x14ECAB4", Offset = "0x14ECAB4", VA = "0x7BBBCECAB4")]
		private void Start()
		{
		}

		// Token: 0x06004669 RID: 18025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004669")]
		[Address(RVA = "0x14ED21C", Offset = "0x14ED21C", VA = "0x7BBBCED21C")]
		private void Update()
		{
		}

		// Token: 0x0600466A RID: 18026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600466A")]
		[Address(RVA = "0x14ED8E0", Offset = "0x14ED8E0", VA = "0x7BBBCED8E0")]
		private void FixedUpdate()
		{
		}

		// Token: 0x0600466B RID: 18027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600466B")]
		[Address(RVA = "0x14ED91C", Offset = "0x14ED91C", VA = "0x7BBBCED91C")]
		private void OnApplicationQuit()
		{
		}

		// Token: 0x0600466C RID: 18028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600466C")]
		[Address(RVA = "0x14EDB10", Offset = "0x14EDB10", VA = "0x7BBBCEDB10")]
		private void OnApplicationPause(bool paused)
		{
		}

		// Token: 0x0600466D RID: 18029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600466D")]
		[Address(RVA = "0x14EDFC4", Offset = "0x14EDFC4", VA = "0x7BBBCEDFC4")]
		private void OnApplicationFocus(bool focus)
		{
		}

		// Token: 0x0600466E RID: 18030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600466E")]
		[Address(RVA = "0x14EE038", Offset = "0x14EE038", VA = "0x7BBBCEE038")]
		private void HandleLog(string logString, string stackTrace, LogType type)
		{
		}

		// Token: 0x0600466F RID: 18031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600466F")]
		[Address(RVA = "0x14EE1B4", Offset = "0x14EE1B4", VA = "0x7BBBCEE1B4")]
		public string GetVersionString()
		{
			return null;
		}

		// Token: 0x06004670 RID: 18032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004670")]
		[Address(RVA = "0x14EE234", Offset = "0x14EE234", VA = "0x7BBBCEE234")]
		public void Restart()
		{
		}

		// Token: 0x06004671 RID: 18033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004671")]
		[Address(RVA = "0x14ED140", Offset = "0x14ED140", VA = "0x7BBBCED140")]
		private void EnterFrontEndGame()
		{
		}

		// Token: 0x06004672 RID: 18034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004672")]
		[Address(RVA = "0x14E9F84", Offset = "0x14E9F84", VA = "0x7BBBCE9F84")]
		private void RefreshConfigData()
		{
		}

		// Token: 0x06004673 RID: 18035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004673")]
		[Address(RVA = "0x14EC8AC", Offset = "0x14EC8AC", VA = "0x7BBBCEC8AC")]
		private void RefreshPrezEnable()
		{
		}

		// Token: 0x06004674 RID: 18036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004674")]
		[Address(RVA = "0x14ED44C", Offset = "0x14ED44C", VA = "0x7BBBCED44C")]
		private void HandleBackButton()
		{
		}

		// Token: 0x06004675 RID: 18037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004675")]
		[Address(RVA = "0x14EE314", Offset = "0x14EE314", VA = "0x7BBBCEE314")]
		public COWGameEntry()
		{
		}

		// Token: 0x06004676 RID: 18038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004676")]
		[Address(RVA = "0x14EE31C", Offset = "0x14EE31C", VA = "0x7BBBCEE31C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113DA58", Offset = "0x113DA58")]
		private void <HandleBackButton>b__19_0()
		{
		}

		// Token: 0x06004677 RID: 18039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004677")]
		[Address(RVA = "0x14EE328", Offset = "0x14EE328", VA = "0x7BBBCEE328")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113DA68", Offset = "0x113DA68")]
		private void <HandleBackButton>b__19_1()
		{
		}

		// Token: 0x040057BC RID: 22460
		[Token(Token = "0x40057BC")]
		[FieldOffset(Offset = "0x18")]
		private GameEngine m_GameEngine;

		// Token: 0x040057BD RID: 22461
		[Token(Token = "0x40057BD")]
		[FieldOffset(Offset = "0x20")]
		private UIPopupMessageBoxController m_QuitDialog;

		// Token: 0x040057BE RID: 22462
		[Token(Token = "0x40057BE")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112F62C", Offset = "0x112F62C")]
		private bool <Paused>k__BackingField;

		// Token: 0x020011AF RID: 4527
		[Token(Token = "0x20011AF")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EAE14", Offset = "0x10EAE14")]
		private sealed class <>c__DisplayClass16_0
		{
			// Token: 0x06004678 RID: 18040 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004678")]
			[Address(RVA = "0x14EE30C", Offset = "0x14EE30C", VA = "0x7BBBCEE30C")]
			public <>c__DisplayClass16_0()
			{
			}

			// Token: 0x06004679 RID: 18041 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004679")]
			[Address(RVA = "0x14EE330", Offset = "0x14EE330", VA = "0x7BBBCEE330")]
			internal void <EnterFrontEndGame>b__0()
			{
			}

			// Token: 0x040057BF RID: 22463
			[Token(Token = "0x40057BF")]
			[FieldOffset(Offset = "0x10")]
			public Scene scene;
		}
	}
}
