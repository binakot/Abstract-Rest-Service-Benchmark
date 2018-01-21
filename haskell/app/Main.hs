module Main where

{-# LANGUAGE OverloadedStrings #-}

import Network.Wai
import Network.Wai.Handler.Warp
import Network.HTTP.Types (status200)
import Blaze.ByteString.Builder (copyByteString)
import Network.HTTP.Types.Header (hContentType)

import Data.ByteString.UTF8 (fromString)
import qualified Data.ByteString.UTF8 as BU
import Data.Monoid

main :: IO ()
main = do
    let port = 8080
    putStrLn $ "Listening on port " ++ show port
    run port app

app :: Request -> (Response -> IO ResponseReceived) -> IO ResponseReceived
app req respond = do
    let api = map fromString ["api", "test"]
    respond $
        case pathInfo req of
            [api] -> helloworld
            _ -> helloworld

helloworld :: Response
helloworld = responseBuilder status200 [ (hContentType, fromString "text/plain") ] $ mconcat $ map copyByteString
    [ fromString "Hello, World!" ]
