using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Networking;

namespace GCommon
{
	// Token: 0x02001006 RID: 4102
	[Token(Token = "0x2001006")]
	public class NetworkDownloadEngine : MonoBehaviour
	{
		// Token: 0x17000722 RID: 1826
		// (get) Token: 0x06003D74 RID: 15732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000722")]
		public static NetworkDownloadEngine Instance
		{
			[Token(Token = "0x6003D74")]
			[Address(RVA = "0x24622B4", Offset = "0x24622B4", VA = "0x7BBCC622B4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000723 RID: 1827
		// (get) Token: 0x06003D75 RID: 15733 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000723")]
		public string ImageCachePath
		{
			[Token(Token = "0x6003D75")]
			[Address(RVA = "0x24625B0", Offset = "0x24625B0", VA = "0x7BBCC625B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003D76 RID: 15734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D76")]
		[Address(RVA = "0x2462460", Offset = "0x2462460", VA = "0x7BBCC62460")]
		private void Init()
		{
		}

		// Token: 0x06003D77 RID: 15735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D77")]
		[Address(RVA = "0x2462C74", Offset = "0x2462C74", VA = "0x7BBCC62C74")]
		private void OnDisable()
		{
		}

		// Token: 0x06003D78 RID: 15736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D78")]
		[Address(RVA = "0x2462D28", Offset = "0x2462D28", VA = "0x7BBCC62D28")]
		private void OnDestroy()
		{
		}

		// Token: 0x06003D79 RID: 15737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D79")]
		[Address(RVA = "0x2462760", Offset = "0x2462760", VA = "0x7BBCC62760")]
		private void GenerateCurrentVersionFolder()
		{
		}

		// Token: 0x06003D7A RID: 15738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D7A")]
		[Address(RVA = "0x246293C", Offset = "0x246293C", VA = "0x7BBCC6293C")]
		private void ClearCacheByVersion()
		{
		}

		// Token: 0x06003D7B RID: 15739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D7B")]
		[Address(RVA = "0x2462DDC", Offset = "0x2462DDC", VA = "0x7BBCC62DDC")]
		private void DeleteCacheWalker(DirectoryInfo folderInfo)
		{
		}

		// Token: 0x06003D7C RID: 15740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D7C")]
		[Address(RVA = "0x2462FA0", Offset = "0x2462FA0", VA = "0x7BBCC62FA0")]
		public void RegisterDownloadTexture(string url, float targetWidth, float targetHeight, NetworkDownloadEngine.OnDowloadFinished finishedCallBack, bool needCache, bool isReadable = false)
		{
		}

		// Token: 0x06003D7D RID: 15741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D7D")]
		[Address(RVA = "0x2463420", Offset = "0x2463420", VA = "0x7BBCC63420")]
		public void DownloadMultiTextures(List<string> url_list, bool needCache = true)
		{
		}

		// Token: 0x06003D7E RID: 15742 RVA: 0x00013410 File Offset: 0x00011610
		[Token(Token = "0x6003D7E")]
		[Address(RVA = "0x2463370", Offset = "0x2463370", VA = "0x7BBCC63370")]
		private bool CheckIsNeedDownload(string url)
		{
			return default(bool);
		}

		// Token: 0x06003D7F RID: 15743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D7F")]
		[Address(RVA = "0x2463818", Offset = "0x2463818", VA = "0x7BBCC63818")]
		public void UnRegisterCallBack(string url, NetworkDownloadEngine.OnDowloadFinished download_callback)
		{
		}

		// Token: 0x06003D80 RID: 15744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D80")]
		[Address(RVA = "0x246396C", Offset = "0x246396C", VA = "0x7BBCC6396C")]
		public void ClearTextureCache()
		{
		}

		// Token: 0x06003D81 RID: 15745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D81")]
		[Address(RVA = "0x2463A38", Offset = "0x2463A38", VA = "0x7BBCC63A38")]
		public void ClearLoadedTextureCache()
		{
		}

		// Token: 0x06003D82 RID: 15746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D82")]
		[Address(RVA = "0x2463A98", Offset = "0x2463A98", VA = "0x7BBCC63A98")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x113BF38", Offset = "0x113BF38")]
		private IEnumerator DownloadImage(NetworkDownloadEngine.DownloadTextureInfo info)
		{
			return null;
		}

		// Token: 0x06003D83 RID: 15747 RVA: 0x00013428 File Offset: 0x00011628
		[Token(Token = "0x6003D83")]
		[Address(RVA = "0x2463B98", Offset = "0x2463B98", VA = "0x7BBCC63B98")]
		private TextureFormat CheckTextureFormatWithBytesAndUrl(byte[] bytes, string url)
		{
			return (TextureFormat)0;
		}

		// Token: 0x06003D84 RID: 15748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D84")]
		[Address(RVA = "0x2464084", Offset = "0x2464084", VA = "0x7BBCC64084")]
		private Texture2D CreateTexture2DWithByte(byte[] data, string url, bool is_readable)
		{
			return null;
		}

		// Token: 0x06003D85 RID: 15749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D85")]
		[Address(RVA = "0x2464C88", Offset = "0x2464C88", VA = "0x7BBCC64C88")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x113BF9C", Offset = "0x113BF9C")]
		private IEnumerator LoadLocalImage(NetworkDownloadEngine.DownloadTextureInfo info)
		{
			return null;
		}

		// Token: 0x06003D86 RID: 15750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D86")]
		[Address(RVA = "0x2464D88", Offset = "0x2464D88", VA = "0x7BBCC64D88")]
		private void LateUpdate()
		{
		}

		// Token: 0x06003D87 RID: 15751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D87")]
		[Address(RVA = "0x24636E8", Offset = "0x24636E8", VA = "0x7BBCC636E8")]
		public static string CheckAndModifyUrlWithPlatFormSuffix(string url)
		{
			return null;
		}

		// Token: 0x06003D88 RID: 15752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D88")]
		[Address(RVA = "0x2465064", Offset = "0x2465064", VA = "0x7BBCC65064")]
		public static string GetFinalUrlWithPlatform(string url)
		{
			return null;
		}

		// Token: 0x06003D89 RID: 15753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D89")]
		[Address(RVA = "0x2463264", Offset = "0x2463264", VA = "0x7BBCC63264")]
		public static string FixedUrlWithRelativePath(string url)
		{
			return null;
		}

		// Token: 0x06003D8A RID: 15754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D8A")]
		[Address(RVA = "0x24650F8", Offset = "0x24650F8", VA = "0x7BBCC650F8")]
		public NetworkDownloadEngine()
		{
		}

		// Token: 0x04004E34 RID: 20020
		[Token(Token = "0x4004E34")]
		[FieldOffset(Offset = "0x0")]
		public static string CDNAddr;

		// Token: 0x04004E35 RID: 20021
		[Token(Token = "0x4004E35")]
		[FieldOffset(Offset = "0x18")]
		public Action<int> OnLoadedImage;

		// Token: 0x04004E36 RID: 20022
		[Token(Token = "0x4004E36")]
		[FieldOffset(Offset = "0x8")]
		private static NetworkDownloadEngine _instance;

		// Token: 0x04004E37 RID: 20023
		[Token(Token = "0x4004E37")]
		private const int MAX_DATA_SIZE = 2097152;

		// Token: 0x04004E38 RID: 20024
		[Token(Token = "0x4004E38")]
		private const int KTX_HEADER_SIZE = 12;

		// Token: 0x04004E39 RID: 20025
		[Token(Token = "0x4004E39")]
		private const int PVR_HEADER_SIZE = 52;

		// Token: 0x04004E3A RID: 20026
		[Token(Token = "0x4004E3A")]
		public const string REGEX_TEXTURE_END = "\\.(([Pp][Nn][Gg]?$)|([Jj][Pp][Gg]?$)|(ktx?$)|(pvr?$))";

		// Token: 0x04004E3B RID: 20027
		[Token(Token = "0x4004E3B")]
		public const string REGEX_PLATFORM_TEXTURE_SURFFIX = "\\.(ff)?$";

		// Token: 0x04004E3C RID: 20028
		[Token(Token = "0x4004E3C")]
		public const string REGEX_ABSOLUTE_URL_SURFFIX = "^((https://)|(http://))";

		// Token: 0x04004E3D RID: 20029
		[Token(Token = "0x4004E3D")]
		[FieldOffset(Offset = "0x20")]
		private string m_CurrentVersionFolder;

		// Token: 0x04004E3E RID: 20030
		[Token(Token = "0x4004E3E")]
		private const string IMAGECAHCE_FOLDER = "ImageCache";

		// Token: 0x04004E3F RID: 20031
		[Token(Token = "0x4004E3F")]
		private const string PREF_KEY_CURRENTVERSIONFOLDER = "CurrentVersionFolder";

		// Token: 0x04004E40 RID: 20032
		[Token(Token = "0x4004E40")]
		[FieldOffset(Offset = "0x10")]
		public static int MAX_MULTI_DOWNLOAD;

		// Token: 0x04004E41 RID: 20033
		[Token(Token = "0x4004E41")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<string, Texture2D> m_LoadedImageCache;

		// Token: 0x04004E42 RID: 20034
		[Token(Token = "0x4004E42")]
		[FieldOffset(Offset = "0x30")]
		private Queue<NetworkDownloadEngine.DownloadTextureInfo> m_NeedDownloadUrls;

		// Token: 0x04004E43 RID: 20035
		[Token(Token = "0x4004E43")]
		[FieldOffset(Offset = "0x38")]
		private HashSet<NetworkDownloadEngine.DownloadTextureInfo> m_RunningDownloadUrls;

		// Token: 0x04004E44 RID: 20036
		[Token(Token = "0x4004E44")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<string, NetworkDownloadEngine.OnDowloadFinished> m_DownloadCallbackDictionary;

		// Token: 0x04004E45 RID: 20037
		[Token(Token = "0x4004E45")]
		[FieldOffset(Offset = "0x18")]
		private static readonly int[] PNG_HEADER;

		// Token: 0x04004E46 RID: 20038
		[Token(Token = "0x4004E46")]
		[FieldOffset(Offset = "0x20")]
		private static readonly int[] KTX_HEADER;

		// Token: 0x04004E47 RID: 20039
		[Token(Token = "0x4004E47")]
		[FieldOffset(Offset = "0x28")]
		private static readonly int[] PVR_HEADER;

		// Token: 0x02001007 RID: 4103
		[Token(Token = "0x2001007")]
		private struct DownloadTextureInfo
		{
			// Token: 0x04004E48 RID: 20040
			[Token(Token = "0x4004E48")]
			[FieldOffset(Offset = "0x0")]
			public string Url;

			// Token: 0x04004E49 RID: 20041
			[Token(Token = "0x4004E49")]
			[FieldOffset(Offset = "0x8")]
			public string Name;

			// Token: 0x04004E4A RID: 20042
			[Token(Token = "0x4004E4A")]
			[FieldOffset(Offset = "0x10")]
			public bool NeedCache;

			// Token: 0x04004E4B RID: 20043
			[Token(Token = "0x4004E4B")]
			[FieldOffset(Offset = "0x14")]
			public Vector2 TragetSize;

			// Token: 0x04004E4C RID: 20044
			[Token(Token = "0x4004E4C")]
			[FieldOffset(Offset = "0x1C")]
			public bool IsDownload;

			// Token: 0x04004E4D RID: 20045
			[Token(Token = "0x4004E4D")]
			[FieldOffset(Offset = "0x1D")]
			public bool IsReadable;
		}

		// Token: 0x02001008 RID: 4104
		// (Invoke) Token: 0x06003D8D RID: 15757
		[Token(Token = "0x2001008")]
		public delegate void OnDowloadFinished(Texture2D texture);

		// Token: 0x02001009 RID: 4105
		[Token(Token = "0x2001009")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EA630", Offset = "0x10EA630")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06003D91 RID: 15761 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003D91")]
			[Address(RVA = "0x2465368", Offset = "0x2465368", VA = "0x7BBCC65368")]
			public <>c()
			{
			}

			// Token: 0x06003D92 RID: 15762 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003D92")]
			[Address(RVA = "0x2465370", Offset = "0x2465370", VA = "0x7BBCC65370")]
			internal void <DownloadMultiTextures>b__30_0(Texture2D texture)
			{
			}

			// Token: 0x04004E4E RID: 20046
			[Token(Token = "0x4004E4E")]
			[FieldOffset(Offset = "0x0")]
			public static readonly NetworkDownloadEngine.<>c <>9;

			// Token: 0x04004E4F RID: 20047
			[Token(Token = "0x4004E4F")]
			[FieldOffset(Offset = "0x8")]
			public static NetworkDownloadEngine.OnDowloadFinished <>9__30_0;
		}

		// Token: 0x0200100A RID: 4106
		[Token(Token = "0x200100A")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EA640", Offset = "0x10EA640")]
		private sealed class <DownloadImage>d__35 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06003D93 RID: 15763 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003D93")]
			[Address(RVA = "0x2463B6C", Offset = "0x2463B6C", VA = "0x7BBCC63B6C")]
			[DebuggerHidden]
			public <DownloadImage>d__35(int <>1__state)
			{
			}

			// Token: 0x06003D94 RID: 15764 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003D94")]
			[Address(RVA = "0x2465374", Offset = "0x2465374", VA = "0x7BBCC65374", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06003D95 RID: 15765 RVA: 0x00013440 File Offset: 0x00011640
			[Token(Token = "0x6003D95")]
			[Address(RVA = "0x2465378", Offset = "0x2465378", VA = "0x7BBCC65378", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000724 RID: 1828
			// (get) Token: 0x06003D96 RID: 15766 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000724")]
			private object Current
			{
				[Token(Token = "0x6003D96")]
				[Address(RVA = "0x24663AC", Offset = "0x24663AC", VA = "0x7BBCC663AC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06003D97 RID: 15767 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003D97")]
			[Address(RVA = "0x24663B4", Offset = "0x24663B4", VA = "0x7BBCC663B4", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000725 RID: 1829
			// (get) Token: 0x06003D98 RID: 15768 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000725")]
			private object Current
			{
				[Token(Token = "0x6003D98")]
				[Address(RVA = "0x246641C", Offset = "0x246641C", VA = "0x7BBCC6641C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04004E50 RID: 20048
			[Token(Token = "0x4004E50")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04004E51 RID: 20049
			[Token(Token = "0x4004E51")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04004E52 RID: 20050
			[Token(Token = "0x4004E52")]
			[FieldOffset(Offset = "0x20")]
			public NetworkDownloadEngine.DownloadTextureInfo info;

			// Token: 0x04004E53 RID: 20051
			[Token(Token = "0x4004E53")]
			[FieldOffset(Offset = "0x40")]
			public NetworkDownloadEngine <>4__this;

			// Token: 0x04004E54 RID: 20052
			[Token(Token = "0x4004E54")]
			[FieldOffset(Offset = "0x48")]
			private UnityWebRequest <www>5__2;

			// Token: 0x04004E55 RID: 20053
			[Token(Token = "0x4004E55")]
			[FieldOffset(Offset = "0x50")]
			private DownloadHandlerBuffer <texDl>5__3;
		}

		// Token: 0x0200100B RID: 4107
		[Token(Token = "0x200100B")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EA650", Offset = "0x10EA650")]
		private sealed class <LoadLocalImage>d__41 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06003D99 RID: 15769 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003D99")]
			[Address(RVA = "0x2464D5C", Offset = "0x2464D5C", VA = "0x7BBCC64D5C")]
			[DebuggerHidden]
			public <LoadLocalImage>d__41(int <>1__state)
			{
			}

			// Token: 0x06003D9A RID: 15770 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003D9A")]
			[Address(RVA = "0x2466424", Offset = "0x2466424", VA = "0x7BBCC66424", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06003D9B RID: 15771 RVA: 0x00013458 File Offset: 0x00011658
			[Token(Token = "0x6003D9B")]
			[Address(RVA = "0x2466428", Offset = "0x2466428", VA = "0x7BBCC66428", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000726 RID: 1830
			// (get) Token: 0x06003D9C RID: 15772 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000726")]
			private object Current
			{
				[Token(Token = "0x6003D9C")]
				[Address(RVA = "0x2466914", Offset = "0x2466914", VA = "0x7BBCC66914", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06003D9D RID: 15773 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003D9D")]
			[Address(RVA = "0x246691C", Offset = "0x246691C", VA = "0x7BBCC6691C", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000727 RID: 1831
			// (get) Token: 0x06003D9E RID: 15774 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000727")]
			private object Current
			{
				[Token(Token = "0x6003D9E")]
				[Address(RVA = "0x2466984", Offset = "0x2466984", VA = "0x7BBCC66984", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04004E56 RID: 20054
			[Token(Token = "0x4004E56")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04004E57 RID: 20055
			[Token(Token = "0x4004E57")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04004E58 RID: 20056
			[Token(Token = "0x4004E58")]
			[FieldOffset(Offset = "0x20")]
			public NetworkDownloadEngine <>4__this;

			// Token: 0x04004E59 RID: 20057
			[Token(Token = "0x4004E59")]
			[FieldOffset(Offset = "0x28")]
			public NetworkDownloadEngine.DownloadTextureInfo info;

			// Token: 0x04004E5A RID: 20058
			[Token(Token = "0x4004E5A")]
			[FieldOffset(Offset = "0x48")]
			private string <filePath>5__2;

			// Token: 0x04004E5B RID: 20059
			[Token(Token = "0x4004E5B")]
			[FieldOffset(Offset = "0x50")]
			private WWW <www>5__3;
		}
	}
}
