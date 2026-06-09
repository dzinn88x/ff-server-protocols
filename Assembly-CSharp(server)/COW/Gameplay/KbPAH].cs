using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using message;
using UnityEngine;

namespace COW.GamePlay
{
	// Token: 0x0200297F RID: 10623
	[Token(Token = "0x200297F")]
	internal abstract class KbP\u0080AH] : MatchGame, ISessionHanlder
	{
		// Token: 0x0600E21E RID: 57886 RVA: 0x0003F048 File Offset: 0x0003D248
		[Token(Token = "0x600E21E")]
		[Address(RVA = "0x1574564", Offset = "0x1574564", VA = "0x7BBBD74564", Slot = "39")]
		public override bool IsOnlineGame()
		{
			return default(bool);
		}

		// Token: 0x0600E21F RID: 57887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E21F")]
		[Address(RVA = "0x157456C", Offset = "0x157456C", VA = "0x7BBBD7456C", Slot = "21")]
		public override LoadingProcess[] GetLoadingProcesses()
		{
			return null;
		}

		// Token: 0x0600E220 RID: 57888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E220")]
		[Address(RVA = "0x157459C", Offset = "0x157459C", VA = "0x7BBBD7459C")]
		public tzE\u0081mS[ ZNVOBgi()
		{
			return null;
		}

		// Token: 0x0600E221 RID: 57889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E221")]
		[Address(RVA = "0x1574620", Offset = "0x1574620", VA = "0x7BBBD74620")]
		public MatchGameClient \u007FdsXJGU()
		{
			return null;
		}

		// Token: 0x0600E222 RID: 57890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E222")]
		[Address(RVA = "0x157466C", Offset = "0x157466C", VA = "0x7BBBD7466C", Slot = "22")]
		public override void OnLoadingFailed(int s\u0080csMrs)
		{
		}

		// Token: 0x0600E223 RID: 57891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E223")]
		[Address(RVA = "0x15749F8", Offset = "0x15749F8", VA = "0x7BBBD749F8", Slot = "23")]
		public override void OnLoadingSceneFailed()
		{
		}

		// Token: 0x0600E224 RID: 57892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E224")]
		[Address(RVA = "0x1574D58", Offset = "0x1574D58", VA = "0x7BBBD74D58")]
		private void p\u0082FlCwK()
		{
		}

		// Token: 0x0600E225 RID: 57893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E225")]
		[Address(RVA = "0x1575014", Offset = "0x1575014", VA = "0x7BBBD75014", Slot = "8")]
		protected override void OnAwake()
		{
		}

		// Token: 0x0600E226 RID: 57894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E226")]
		[Address(RVA = "0x1575104", Offset = "0x1575104", VA = "0x7BBBD75104", Slot = "9")]
		protected override void OnSceneLoaded()
		{
		}

		// Token: 0x0600E227 RID: 57895 RVA: 0x0003F060 File Offset: 0x0003D260
		[Token(Token = "0x600E227")]
		[Address(RVA = "0x15754B0", Offset = "0x15754B0", VA = "0x7BBBD754B0", Slot = "6")]
		public override bool NeedPreloadBeforeLoadScene()
		{
			return default(bool);
		}

		// Token: 0x0600E228 RID: 57896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E228")]
		[Address(RVA = "0x15754B8", Offset = "0x15754B8", VA = "0x7BBBD754B8", Slot = "10")]
		protected override void OnPreloadLoaded()
		{
		}

		// Token: 0x0600E229 RID: 57897 RVA: 0x0003F078 File Offset: 0x0003D278
		[Token(Token = "0x600E229")]
		[Address(RVA = "0x1575548", Offset = "0x1575548", VA = "0x7BBBD75548", Slot = "4")]
		public override uint GetPreloadCountPerFrame()
		{
			return 0U;
		}

		// Token: 0x0600E22A RID: 57898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E22A")]
		[Address(RVA = "0x15755B0", Offset = "0x15755B0", VA = "0x7BBBD755B0", Slot = "50")]
		public void OnPingSent(int ~soMqi[)
		{
		}

		// Token: 0x0600E22B RID: 57899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E22B")]
		[Address(RVA = "0x1575634", Offset = "0x1575634", VA = "0x7BBBD75634", Slot = "48")]
		public void OnConnected(bool AIVN\u0082oj)
		{
		}

		// Token: 0x0600E22C RID: 57900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E22C")]
		[Address(RVA = "0x15757C0", Offset = "0x15757C0", VA = "0x7BBBD757C0", Slot = "49")]
		public void OnDisconnected(DisconnectedReason O\u0080[pV^Y)
		{
		}

		// Token: 0x0600E22D RID: 57901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E22D")]
		[Address(RVA = "0x1575CA8", Offset = "0x1575CA8", VA = "0x7BBBD75CA8")]
		private void rIhSeOR(params object[] QmG~NaB)
		{
		}

		// Token: 0x0600E22E RID: 57902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E22E")]
		[Address(RVA = "0x15777C8", Offset = "0x15777C8", VA = "0x7BBBD777C8")]
		private void |sTYr^Q(params object[] QmG~NaB)
		{
		}

		// Token: 0x0600E22F RID: 57903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E22F")]
		[Address(RVA = "0x15777F0", Offset = "0x15777F0", VA = "0x7BBBD777F0")]
		private void gqGBlMq(params object[] QmG~NaB)
		{
		}

		// Token: 0x0600E230 RID: 57904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E230")]
		[Address(RVA = "0x1577858", Offset = "0x1577858", VA = "0x7BBBD77858")]
		private void imqtvYQ(params object[] QmG~NaB)
		{
		}

		// Token: 0x0600E231 RID: 57905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E231")]
		[Address(RVA = "0x1577880", Offset = "0x1577880", VA = "0x7BBBD77880", Slot = "12")]
		protected override void OnUpdate()
		{
		}

		// Token: 0x0600E232 RID: 57906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E232")]
		[Address(RVA = "0x15783F0", Offset = "0x15783F0", VA = "0x7BBBD783F0", Slot = "14")]
		protected override void OnFixedUpdate()
		{
		}

		// Token: 0x0600E233 RID: 57907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E233")]
		[Address(RVA = "0x15784B0", Offset = "0x15784B0", VA = "0x7BBBD784B0", Slot = "15")]
		protected override void OnNetworkFixedUpdate()
		{
		}

		// Token: 0x0600E234 RID: 57908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E234")]
		[Address(RVA = "0x15784D8", Offset = "0x15784D8", VA = "0x7BBBD784D8", Slot = "11")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x0600E235 RID: 57909 RVA: 0x0003F090 File Offset: 0x0003D290
		[Token(Token = "0x600E235")]
		[Address(RVA = "0x15785B4", Offset = "0x15785B4", VA = "0x7BBBD785B4", Slot = "24")]
		public override int GetGameType()
		{
			return 0;
		}

		// Token: 0x0600E236 RID: 57910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E236")]
		[Address(RVA = "0x15785BC", Offset = "0x15785BC", VA = "0x7BBBD785BC")]
		public void Qn^BqG}(qu^f\u0081by K{\u0080cyv\u007F)
		{
		}

		// Token: 0x0600E237 RID: 57911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E237")]
		[Address(RVA = "0x157886C", Offset = "0x157886C", VA = "0x7BBBD7886C")]
		public void }vmaApH(uint |Dl^iZk)
		{
		}

		// Token: 0x0600E238 RID: 57912 RVA: 0x0003F0A8 File Offset: 0x0003D2A8
		[Token(Token = "0x600E238")]
		[Address(RVA = "0x15788BC", Offset = "0x15788BC", VA = "0x7BBBD788BC")]
		public float \u0081c\u0082}IMk()
		{
			return 0f;
		}

		// Token: 0x0600E239 RID: 57913 RVA: 0x0003F0C0 File Offset: 0x0003D2C0
		[Token(Token = "0x600E239")]
		[Address(RVA = "0x1578928", Offset = "0x1578928", VA = "0x7BBBD78928")]
		public uint JxTpQwz()
		{
			return 0U;
		}

		// Token: 0x0600E23A RID: 57914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E23A")]
		[Address(RVA = "0x1578974", Offset = "0x1578974", VA = "0x7BBBD78974")]
		private void KMA}gdR(ResourceID[] K{\u0080cyv\u007F, ref List<ResourceID> \u0080if}a|L)
		{
		}

		// Token: 0x0600E23B RID: 57915 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E23B")]
		[Address(RVA = "0x1578ACC", Offset = "0x1578ACC", VA = "0x7BBBD78ACC", Slot = "19")]
		public override ResourceID[] GetPreloadResourceID()
		{
			return null;
		}

		// Token: 0x0600E23C RID: 57916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E23C")]
		[Address(RVA = "0x1578D68", Offset = "0x1578D68", VA = "0x7BBBD78D68", Slot = "20")]
		public override ResourceID[] GetAudioPreloadResourceID()
		{
			return null;
		}

		// Token: 0x0600E23D RID: 57917 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E23D")]
		[Address(RVA = "0x1578CE4", Offset = "0x1578CE4", VA = "0x7BBBD78CE4")]
		private ResourceID[] ByuvJKa()
		{
			return null;
		}

		// Token: 0x0600E23E RID: 57918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E23E")]
		[Address(RVA = "0x1578F38", Offset = "0x1578F38", VA = "0x7BBBD78F38", Slot = "51")]
		protected virtual void \u0081z]izKn()
		{
		}

		// Token: 0x0600E23F RID: 57919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E23F")]
		[Address(RVA = "0x1578F3C", Offset = "0x1578F3C", VA = "0x7BBBD78F3C", Slot = "33")]
		public override void PauseGame(bool lyabLZX)
		{
		}

		// Token: 0x0600E240 RID: 57920 RVA: 0x0003F0D8 File Offset: 0x0003D2D8
		[Token(Token = "0x600E240")]
		[Address(RVA = "0x15792B4", Offset = "0x15792B4", VA = "0x7BBBD792B4", Slot = "34")]
		public override bool IsGamePaused()
		{
			return default(bool);
		}

		// Token: 0x0600E241 RID: 57921 RVA: 0x0003F0F0 File Offset: 0x0003D2F0
		[Token(Token = "0x600E241")]
		[Address(RVA = "0x15792BC", Offset = "0x15792BC", VA = "0x7BBBD792BC", Slot = "52")]
		public virtual bool DlGX~v[()
		{
			return default(bool);
		}

		// Token: 0x0600E242 RID: 57922 RVA: 0x0003F108 File Offset: 0x0003D308
		[Token(Token = "0x600E242")]
		[Address(RVA = "0x15792C4", Offset = "0x15792C4", VA = "0x7BBBD792C4", Slot = "53")]
		public virtual bool BugN~z{()
		{
			return default(bool);
		}

		// Token: 0x0600E243 RID: 57923 RVA: 0x0003F120 File Offset: 0x0003D320
		[Token(Token = "0x600E243")]
		[Address(RVA = "0x15792CC", Offset = "0x15792CC", VA = "0x7BBBD792CC")]
		public bool SWahBNQ(ulong z^hr]Er)
		{
			return default(bool);
		}

		// Token: 0x0600E244 RID: 57924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E244")]
		[Address(RVA = "0x1579360", Offset = "0x1579360", VA = "0x7BBBD79360", Slot = "46")]
		public override Player CreatePlayer(Transform i~Bf~sj, ulong z^hr]Er, ulong aj[QH\u0080w, {QAb\u0082~u BhUcw{z, bool Z~RaYh~ = false, [Optional] object ldzAD`u)
		{
			return null;
		}

		// Token: 0x0600E245 RID: 57925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E245")]
		[Address(RVA = "0x1579488", Offset = "0x1579488", VA = "0x7BBBD79488")]
		protected KbP\u0080AH]()
		{
		}

		// Token: 0x040110A3 RID: 69795
		[Token(Token = "0x40110A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<uint, string> \u0080gcuHLE;

		// Token: 0x040110A4 RID: 69796
		[Token(Token = "0x40110A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		protected long m\u007FswfOL;

		// Token: 0x040110A5 RID: 69797
		[Token(Token = "0x40110A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		protected HashSet<ResourceID> hBM\u0081CBZ;

		// Token: 0x040110A6 RID: 69798
		[Token(Token = "0x40110A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly Vector3 R|r\u0081\u0082]x;

		// Token: 0x040110A7 RID: 69799
		[Token(Token = "0x40110A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private static readonly Vector3 jOKNWpD;

		// Token: 0x040110A8 RID: 69800
		[Token(Token = "0x40110A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private GameObject BROnVvD;

		// Token: 0x040110A9 RID: 69801
		[Token(Token = "0x40110A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Transform fAcECEt;

		// Token: 0x040110AA RID: 69802
		[Token(Token = "0x40110AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Transform xiOwgVZ;

		// Token: 0x040110AB RID: 69803
		[Token(Token = "0x40110AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private float f|`;

		// Token: 0x040110AC RID: 69804
		[Token(Token = "0x40110AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		public uint KNftVVL;

		// Token: 0x040110AD RID: 69805
		[Token(Token = "0x40110AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public ulong BKTqKom;

		// Token: 0x040110AE RID: 69806
		[Token(Token = "0x40110AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private ulong MSy^X[j;

		// Token: 0x040110AF RID: 69807
		[Token(Token = "0x40110AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public uint XbYx\u0080Gs;

		// Token: 0x040110B0 RID: 69808
		[Token(Token = "0x40110B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		public uint Nh{{IA|;

		// Token: 0x040110B1 RID: 69809
		[Token(Token = "0x40110B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public float brPPBnC;

		// Token: 0x040110B2 RID: 69810
		[Token(Token = "0x40110B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private byte[] QmG~NaB;
	}
}
